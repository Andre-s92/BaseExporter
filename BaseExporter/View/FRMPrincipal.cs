using BaseExporter.Controller;
using System;
using System.Drawing;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace BaseExporter
{
    public partial class FRMPrincipal : Form
    {
        CheckBox HeaderCheckBox = null;
        int TotalCheckBoxes = 0;
        int TotalCheckedCheckBoxes = 0;
        bool IsHeaderCheckBoxClicked = false;
        string p_model, p_service,Tabela;
        PrincipalControlller Principal = new PrincipalControlller();
        public FRMPrincipal()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            
            Principal.BuscarTabelas(grid_tabelas);
        }


        private void FRMPrincipal_Load(object sender, EventArgs e)
        {
            AddHeaderCheckBox();
            HeaderCheckBox.KeyUp += new KeyEventHandler(HeaderCheckBox_KeyUp);
            HeaderCheckBox.MouseClick += new MouseEventHandler(HeaderCheckBox_MouseClick);
            grid_colunas.CellValueChanged += new DataGridViewCellEventHandler(grid_colunas_CellValueChanged);
            grid_colunas.CurrentCellDirtyStateChanged += new EventHandler(grid_colunas_CurrentCellDirtyStateChanged);
            grid_colunas.CellPainting += new DataGridViewCellPaintingEventHandler(grid_colunas_CellPainting);
            Principal.BuscarTabelas(grid_tabelas);
            cb_model.Checked = true;
            cb_service.Checked = true;
        }
        private void grid_colunas_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!IsHeaderCheckBoxClicked)
                RowCheckBoxClick((DataGridViewCheckBoxCell)grid_colunas[e.ColumnIndex, e.RowIndex]);
        }

        private void grid_colunas_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (grid_colunas.CurrentCell is DataGridViewCheckBoxCell)
                grid_colunas.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void HeaderCheckBox_MouseClick(object sender, MouseEventArgs e)
        {
            HeaderCheckBoxClick((CheckBox)sender);
        }

        private void HeaderCheckBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                HeaderCheckBoxClick((CheckBox)sender);
        }

        private void grid_colunas_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == 0)
                ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex);
        }
        private void AddHeaderCheckBox()
        {
            HeaderCheckBox = new CheckBox();
            HeaderCheckBox.Size = new Size(15, 15);
            this.grid_colunas.Controls.Add(HeaderCheckBox);
        }
        private void ResetHeaderCheckBoxLocation(int ColumnIndex, int RowIndex)
        {
            Rectangle oRectangle = this.grid_colunas.GetCellDisplayRectangle(ColumnIndex, RowIndex, true);

            Point oPoint = new Point();
            oPoint.X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBox.Width) / 2 + 1;
            oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBox.Height) / 2 + 1;
            HeaderCheckBox.Location = oPoint;
        }

        private void HeaderCheckBoxClick(CheckBox HCheckBox)
        {
            IsHeaderCheckBoxClicked = true;

            foreach (DataGridViewRow Row in grid_colunas.Rows)
                ((DataGridViewCheckBoxCell)Row.Cells["Select"]).Value = HCheckBox.Checked;

            grid_colunas.RefreshEdit();
            TotalCheckedCheckBoxes = HCheckBox.Checked ? TotalCheckBoxes : 0;
            IsHeaderCheckBoxClicked = false;
        }

        private void RowCheckBoxClick(DataGridViewCheckBoxCell RCheckBox)
        {
            if (RCheckBox != null)
            {       
                if ((bool)RCheckBox.Value && TotalCheckedCheckBoxes < TotalCheckBoxes)
                    TotalCheckedCheckBoxes++;
                else if (TotalCheckedCheckBoxes > 0)
                    TotalCheckedCheckBoxes--;

                if (TotalCheckedCheckBoxes < TotalCheckBoxes)
                    HeaderCheckBox.Checked = false;
                else if (TotalCheckedCheckBoxes == TotalCheckBoxes)
                    HeaderCheckBox.Checked = true;
            }
        }

        private void grid_tabelas_DoubleClick(object sender, EventArgs e)
        {
            Tabela = grid_tabelas.CurrentRow.Cells[0].Value.ToString();
            Principal.BuscarColunas(grid_colunas, Tabela);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.RootFolder = Environment.SpecialFolder.Desktop;
                fbd.Description = "Localizar destino do Model";
                fbd.ShowNewFolderButton = false;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    lb_dest_model.Text = fbd.SelectedPath + "\\";
                    p_model = fbd.SelectedPath + "\\";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar caminho" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbd = new FolderBrowserDialog();
                fbd.RootFolder = Environment.SpecialFolder.Desktop;
                fbd.Description = "Localizar destino do Services";
                fbd.ShowNewFolderButton = false;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    lb_dest_services.Text = fbd.SelectedPath + "\\";
                    p_service = fbd.SelectedPath + "\\";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar caminho" + ex, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void WriteToFile(object text,string path)
        {

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(text);
                writer.Close();
            }
        }
        public void ModelBuilder()
        {
            if (string.IsNullOrEmpty(p_model))
            {
                errorProvider1.SetError(bt_model, "Selecione um diretório para salvar o arquivo");
            }
            else
            {
                errorProvider1.SetError(bt_model, "");
                string arquivo_model = Path.Combine(p_model, JsonNamingPolicy.CamelCase.ConvertName(Tabela) + ".model.ts");
                string Parte1 = "import { ObjectMapper } from 'json-object-mapper'; \n" +
                    "\n" +
                   $"export class {Tabela}Model extends Model implements IModel<{Tabela}Model>" +
                   " {" +
                   "\n";
                WriteToFile(Parte1, arquivo_model);
                foreach (DataGridViewRow dr in grid_colunas.Rows)
                {
                    string coluna = grid_colunas.Rows[dr.Index].Cells[1].Value.ToString();

                    if (dr.Cells[0].Value != null)
                    {
                        WriteToFile(coluna + " = '';", arquivo_model);
                    }
                }
                string Parte2 = "\n" +
                    $"static create(input: any): {Tabela}Model " +
                    "{\n" +
                    $"   const res = ObjectMapper.deserialize<{Tabela}Model>({Tabela}Model, input);\n" +
                    "   return res;\n" +
                    " }\n" +
                    "}";
                WriteToFile(Parte2, arquivo_model);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public void ServiceBuilder()
        {
            Tabela = grid_tabelas.CurrentRow.Cells[0].Value.ToString();
            if (string.IsNullOrEmpty(p_service))
            {
                errorProvider1.SetError(bt_service, "Selecione um diretório para salvar o arquivo");
            }
            else
            {
                errorProvider1.SetError(bt_service, "");
                string arquivo_service = Path.Combine(p_service, JsonNamingPolicy.CamelCase.ConvertName(Tabela) + ".service.ts");
                string Service = "import { HttpService } from './http.service';\r\n" +
                    "import { Injectable } from '@angular/core';\r\n" +
                    "\r\n" +
                    "@Injectable({ providedIn: 'root' })\r\n" +
                    $"export class {Tabela}Service extends ServiceBase<{Tabela}Model>" +
                    " {\r\n " +
                    "\r\n" +
                    "  constructor(http: HttpService) {\r\n " +
                    $"   super('{Tabela}', http);\r\n " +
                    " }\r\n " +
                    "\r\n " +
                    $" createEntity(input: any): {Tabela}Model" +
                    " {\r\n" +
                    $"    return {Tabela}Model.create(input);\r\n " +
                    " }\r\n " +
                    "\r\n" +
                    "}";
                WriteToFile(Service, arquivo_service);
                
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (cb_model.Checked == true)
            {
                ModelBuilder();
            }
            if (cb_service.Checked == true)
            {
                ServiceBuilder();
            }

        }
    }
}
