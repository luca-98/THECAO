using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Configuration;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;
namespace THECAOTOOL {
    public partial class Form1 : Form {
        string strConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["THECAOTOOL.Properties.Settings.THECAOConnectionString"].ToString();
        SqlConnection con;
        System.Data.DataTable dtValue;
        System.Data.DataTable dtManufacturer;
        System.Data.DataTable dtStatus;
        string currentID;
        int numrow;
        string filterSql;
        public Form1() {
            InitializeComponent();
            con = new SqlConnection(strConnectionString);
            handleImportExport(false);
            loadDataGridView();
            loadDataValue();
            loadManufacturer();
            loadStatus();
            loadName();
            diDate.Value = DateTime.Now;
            cbeName.Enabled = false;
            cbeStatus.Enabled = false;
            cbeValue.Enabled = false;
            btnExport.Enabled = false;
            cbeManufacturer.Enabled = false;
        }

        private void Form1_Load(object sender,EventArgs e) {

        }
        private void loadDataValue() {
            dtValue = new System.Data.DataTable();
            con.Open();
            try {
                SqlDataAdapter da = new SqlDataAdapter("Select * From MENHGIA",con);
                da.Fill(dtValue);

            } catch (Exception ex) {
                throw new Exception("Error " + ex.ToString());
            } finally {
                con.Close();
            }


            try {
                cbiValue.DataSource = dtValue;
                cbiValue.DisplayMember = "NAME";
                cbiValue.ValueMember = "ID";
                cbeValue.DataSource = dtValue;
                cbeValue.DisplayMember = "NAME";
                cbeValue.ValueMember = "ID";
            } catch (Exception ex) {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n",ex.ToString());
            }
        }
        private void loadManufacturer() {
            dtManufacturer = new System.Data.DataTable();
            con.Open();
            try {
                SqlDataAdapter da = new SqlDataAdapter("Select * From HANGSANXUAT",con);
                da.Fill(dtManufacturer);

            } catch (Exception ex) {
                throw new Exception("Error " + ex.ToString());
            } finally {
                con.Close();
            }

            try {
                cbiManufacturer.DataSource = dtManufacturer;
                cbiManufacturer.DisplayMember = "NAME";
                cbiManufacturer.ValueMember = "ID";
                cbeManufacturer.DataSource = dtManufacturer;
                cbeManufacturer.DisplayMember = "NAME";
                cbeManufacturer.ValueMember = "ID";

            } catch (Exception ex) {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n",ex.ToString());
            }
        }
        private void loadStatus() {
            dtStatus = new System.Data.DataTable();
            con.Open();
            try {
                SqlDataAdapter da = new SqlDataAdapter("Select * From TRANGTHAI",con);
                da.Fill(dtStatus);

            } catch (Exception ex) {
                throw new Exception("Error " + ex.ToString());
            } finally {
                con.Close();
            }

            try {
                cbiStatus.DataSource = dtStatus;
                cbiStatus.DisplayMember = "NAME";
                cbiStatus.ValueMember = "ID";
                cbeStatus.DataSource = dtStatus;
                cbeStatus.DisplayMember = "NAME";
                cbeStatus.ValueMember = "ID";
            } catch (Exception ex) {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n",ex.ToString());
            }
        }
        private void loadName() {
            System.Data.DataTable dt = new System.Data.DataTable();
            con.Open();
            try {
                SqlDataAdapter da = new SqlDataAdapter("Select DISTINCT  MAIN.NAME From MAIN",con);
                da.Fill(dt);

            } catch (Exception ex) {
                throw new Exception("Error " + ex.ToString());
            } finally {
                con.Close();
            }

            try {
                cbeName.DataSource = dt;
                cbeName.DisplayMember = "NAME";

            } catch (Exception ex) {
                MessageBox.Show("Có lỗi khi load dữ liệu!\n",ex.ToString());
            }
        }
        private void loadDataGridView() {
            SqlCommand cmd = new SqlCommand("SELECT  MAIN.NAME, MAIN.ID, MAIN.SERI,HANGSANXUAT.NAME ,MENHGIA.NAME ,MAIN.NGAYNHAP,TRANGTHAI.NAME "
                                          + "FROM  MAIN JOIN "
                                          + "HANGSANXUAT ON HANGSANXUAT.ID = MAIN.NHASANXUAT  JOIN "
                                          + "MENHGIA ON MAIN.MENHGIA = MENHGIA.ID  JOIN "
                                          + "TRANGTHAI ON MAIN.TRANGTHAI = TRANGTHAI.ID ;",con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void DateTimePicker1_ValueChanged(object sender,EventArgs e) {

        }

        private void Label5_Click(object sender,EventArgs e) {

        }

        private void Label9_Click(object sender,EventArgs e) {

        }

        private void TextBox5_TextChanged(object sender,EventArgs e) {

        }

        private void RImport_CheckedChanged(object sender,EventArgs e) {
            if (rImport.Checked) {
                handleImportExport(false);
            } else {
                handleImportExport(true);
                loadDataValue();
                loadManufacturer();
                loadStatus();
                loadName();
            }

        }
        void handleImportExport(bool status) {
            btnExport.Enabled = status;
            tbQuantity.Enabled = status;
            cbiStatus.Enabled = !status;
            tbiID.Enabled = !status;
            tbiName.Enabled = !status;
            tbiSeri.Enabled = !status;
            cbiValue.Enabled = !status;
            diDate.Enabled = !status;
            btnImport.Enabled = !status;
            btnUpdate.Enabled = !status;
            cbiManufacturer.Enabled = !status;

        }
        string validateSQL(int type) {
            string name = tbiName.Text;
            string id = tbiID.Text;
            string seri = tbiSeri.Text;
            string nhaSanXuat = cbiManufacturer.SelectedValue.ToString();
            string menhGia = cbiValue.SelectedValue.ToString();
            string ngayNhap = diDate.Value.ToShortDateString();
            string trangthai = cbiStatus.SelectedValue.ToString();
            string sql;
            //something validate data :v
            if (type == 1) {
                sql = "insert into Main (ID,NAME,SERI,NHASANXUAT,MENHGIA,NGAYNHAP,TRANGTHAI) values(N'" + id + "',N'" + name + "',N'" + seri + "'," + nhaSanXuat + "," + menhGia + ",CAST(N'" + ngayNhap + "' AS Date)," + trangthai + ")";
            } else {
                sql = "update Main set ID = N'" + id + "', NAME = N'" + name + "', SERI = N'" + seri + "', NHASANXUAT = " + nhaSanXuat + ", MENHGIA = " + menhGia + ", NGAYNHAP = CAST(N'" + ngayNhap + "' AS Date), TRANGTHAI = " + trangthai + " where ID = '" + currentID + "'";
            }
            return sql;
        }
        private void BtnImport_Click(object sender,EventArgs e) {

            string sql = validateSQL(1);
            try {
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.InsertCommand = new SqlCommand(sql,con);
                adapter.InsertCommand.ExecuteNonQuery();
                loadDataGridView();

            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            } finally {
                con.Close();
            }
        }

        private void BtnUpdate_Click(object sender,EventArgs e) {
            DialogResult dr = MessageBox.Show("Bạn có muốn Update không?","Xác Nhận",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (dr == DialogResult.Yes) {
                string sql = validateSQL(2);
                try {
                    con.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.InsertCommand = new SqlCommand(sql,con);
                    adapter.InsertCommand.ExecuteNonQuery();
                    loadDataGridView();

                } catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                } finally {
                    con.Close();
                }
                currentID = tbiID.Text;
            }

        }

        private void CbiValue_SelectedIndexChanged(object sender,EventArgs e) {

        }



        private void Button2_Click(object sender,EventArgs e) {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = @"C:\'";
            saveFileDialog1.Title = "Save excel Files";
            saveFileDialog1.DefaultExt = "xlsx";
            saveFileDialog1.Filter = "Text files (*.xlsx)|*.xlsx";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "1";
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++) {
                    worksheet.Cells[1,i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++) {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++) {
                        worksheet.Cells[i + 2,j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                workbook.SaveAs(saveFileDialog1.FileName);
            }

        }

        private void DataGridView1_CellClick(object sender,DataGridViewCellEventArgs e) {

            numrow = e.RowIndex;
            currentID = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
            tbiName.Text = dataGridView1.Rows[numrow].Cells[0].Value.ToString();
            tbiID.Text = dataGridView1.Rows[numrow].Cells[1].Value.ToString();
            tbiSeri.Text = dataGridView1.Rows[numrow].Cells[2].Value.ToString();
            foreach (DataRow item in dtValue.Rows) {
                if (item.ItemArray[1].Equals(dataGridView1.Rows[numrow].Cells[4].Value.ToString())) {
                    cbiValue.SelectedValue = item.ItemArray[0];
                    break;
                }
            }
            foreach (DataRow item in dtManufacturer.Rows) {
                if (item.ItemArray[1].Equals(dataGridView1.Rows[numrow].Cells[3].Value.ToString())) {
                    cbiManufacturer.SelectedValue = item.ItemArray[0];
                    break;
                }
            }
            foreach (DataRow item in dtStatus.Rows) {
                if (item.ItemArray[1].Equals(dataGridView1.Rows[numrow].Cells[6].Value.ToString())) {
                    cbiStatus.SelectedValue = item.ItemArray[0];
                    break;
                }
            }
            diDate.Value = Convert.ToDateTime(dataGridView1.Rows[numrow].Cells[5].Value);

        }

        private void BtnExport_Click(object sender,EventArgs e) {
            loadDataGridViewBY();
        }

        private void CStatus_CheckedChanged(object sender,EventArgs e) {
            if (cStatus.Checked) {
                cbeStatus.Enabled = true;
            } else {
                cbeStatus.Enabled = false;

            }

        }

        private void CHangSanXuat_CheckedChanged(object sender,EventArgs e) {
            if (cHangSanXuat.Checked) {
                cbeManufacturer.Enabled = true;
            } else {
                cbeManufacturer.Enabled = false;
            }
        }

        private void CValue_CheckedChanged(object sender,EventArgs e) {
            if (cValue.Checked) {
                cbeValue.Enabled = true;
            } else {
                cbeValue.Enabled = false;
            }
        }

        private void CName_CheckedChanged(object sender,EventArgs e) {
            if (cName.Checked) {
                cbeName.Enabled = true;
            } else {
                cbeName.Enabled = false;
            }

        }
        private void loadDataGridViewBY() {
            string quantity = "";
            if (!tbQuantity.Text.Equals("")) {
                quantity = " top " + tbQuantity.Text;
            }
            string name = cbeName.Text;
            string nhaSanXuat = cbeManufacturer.SelectedValue.ToString();
            string menhGia = cbeValue.SelectedValue.ToString();
            string trangthai = cbeStatus.SelectedValue.ToString();
            filterSql = "SELECT " + quantity + " MAIN.NAME, MAIN.ID, MAIN.SERI,HANGSANXUAT.NAME ,MENHGIA.NAME ,MAIN.NGAYNHAP,TRANGTHAI.NAME "
                                          + "FROM  MAIN JOIN "
                                          + "HANGSANXUAT ON HANGSANXUAT.ID = MAIN.NHASANXUAT  JOIN "
                                          + "MENHGIA ON MAIN.MENHGIA = MENHGIA.ID  JOIN "
                                          + "TRANGTHAI ON MAIN.TRANGTHAI = TRANGTHAI.ID ";
            if (cHangSanXuat.Checked || cStatus.Checked || cValue.Checked || cName.Checked) {
                filterSql += " where ";
                if (cHangSanXuat.Checked) {
                    filterSql += " MAIN.NHASANXUAT = '" + nhaSanXuat + "'";
                    if (cStatus.Checked || cValue.Checked || cName.Checked) {
                        filterSql += " and ";
                    }
                }
                if (cStatus.Checked) {
                    filterSql += " MAIN.TRANGTHAI = '" + trangthai + "'";
                    if (cValue.Checked || cName.Checked) {
                        filterSql += " and ";
                    }
                }
                if (cValue.Checked) {
                    filterSql += " MAIN.MENHGIA = '" + menhGia + "'";
                    if (cName.Checked) {
                        filterSql += " and ";
                    }
                }
                if (cName.Checked) {
                    filterSql += " MAIN.NAME = '" + name + "'";
                }
            }
            SqlCommand cmd = new SqlCommand(filterSql,con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            System.Data.DataTable dt = new System.Data.DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Button1_Click(object sender,EventArgs e) {
            string name = tbiName.Text;
            string nhaSanXuat = cbiManufacturer.SelectedValue.ToString();
            string menhGia = cbiValue.SelectedValue.ToString();
            string ngayNhap = diDate.Value.ToShortDateString();
            string trangthai = cbiStatus.SelectedValue.ToString();
            OpenFileDialog openFileDialog1 = new OpenFileDialog {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "xlsx",
                Filter = "xlsx files (*.xlsx)|*.xlsx",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK) {

                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(openFileDialog1.FileName);
                Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

                int rowCount = xlRange.Rows.Count;
                int colCount = xlRange.Columns.Count;
                string id = "";
                string seri = "";
                con.Open();
                try {
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    for (int i = 1; i <= rowCount; i++) {
                        id = xlRange.Cells[i,1].Value2.ToString();
                        seri = xlRange.Cells[i,2].Value2.ToString();
                        string sql = sql = "insert into Main (ID,NAME,SERI,NHASANXUAT,MENHGIA,NGAYNHAP,TRANGTHAI) values(N'" + id + "',N'" + name + "',N'" + seri + "'," + nhaSanXuat + "," + menhGia + ",CAST(N'" + ngayNhap + "' AS Date)," + trangthai + ")";
                        adapter.InsertCommand = new SqlCommand(sql,con);
                        adapter.InsertCommand.ExecuteNonQuery();
                    }


                    MessageBox.Show("thanh cong");
                } catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                } finally {
                    con.Close();
                    //cleanup  
                    loadDataGridView();
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    Marshal.ReleaseComObject(xlRange);
                    Marshal.ReleaseComObject(xlWorksheet);

                    //close and release  
                    xlWorkbook.Close();
                    Marshal.ReleaseComObject(xlWorkbook);

                    //quit and release  
                    xlApp.Quit();
                    Marshal.ReleaseComObject(xlApp);
                }




            }

        }
    }
}
