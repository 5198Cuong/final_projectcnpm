using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;
namespace FinalProject
{
    public partial class Main : Form
    {
        OleDbCommand cmd;
        OleDbDataAdapter da;
        private BindingSource bindingSource = null;
        private OleDbCommandBuilder oleCommandBuilder = null;
        DataTable dt = new DataTable();
        //Read connection string from App.Config with name: MyConnOleDb
        String strConn = ConfigurationManager.ConnectionStrings["MyConnOleDb"].ConnectionString;
        SqlConnection connGeneral = new SqlConnection(ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString);
        DataGridViewRow selectedrow;
        String selectedID;
        String selectedName;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            DataBindProducts();

            dateTimePickerorder.Format = DateTimePickerFormat.Custom;
            dateTimePickerorder.CustomFormat = "yyyy-MM-dd";
            String t = dateTimePickerorder.Value.ToString("yyyy - MM - dd");
            
            connGeneral.Open();
            SqlCommand cmdR = new SqlCommand("select * from ReceivedNote",connGeneral);
            SqlDataAdapter adapterR = new SqlDataAdapter(cmdR);
            DataTable dtR = new DataTable();
            adapterR.Fill(dtR);
            dataGridViewReceive.DataSource = dtR;

            SqlCommand cmdO = new SqlCommand("select * from OrdersStatus", connGeneral);
            SqlDataAdapter adapterO = new SqlDataAdapter(cmdO);
            DataTable dtO = new DataTable();
            adapterO.Fill(dtO);
            dataGridViewOrder.DataSource = dtO;

            SqlCommand cmdd = new SqlCommand("select * from DeliveryNote", connGeneral);
            SqlDataAdapter adapterd = new SqlDataAdapter(cmdd);
            DataTable dtd = new DataTable();
            adapterd.Fill(dtd);
            dataGridViewDelivery.DataSource = dtd;


        }


        private void DataBindProducts()
        {
            dataGridView1.DataSource = null;
            dt.Clear();
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            String sSQL = "select * from Products";
            cmd = conn.CreateCommand();
            cmd.CommandText = sSQL;
            try
            {
                da = new OleDbDataAdapter(sSQL, conn);
                oleCommandBuilder = new OleDbCommandBuilder(da);
                da.Fill(dt);
                bindingSource = new BindingSource { DataSource = dt };
                dataGridView1.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();

            

        }
      

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Length > 0 && txtName.Text.Length>0 && txtRPrice.Text.Length >0 && txtQuantity.Text.Length > 0 && txtDPrice.Text.Length>0)
            {
                OleDbConnection conn = new OleDbConnection(strConn);
                conn.Open();
                String sQL = "Insert Products values('" + txtID.Text + "','" + txtName.Text + "'," + txtQuantity.Text + "," + txtRPrice.Text + ","+txtDPrice.Text+")";
                OleDbCommand cmd = conn.CreateCommand();
                cmd.CommandText = sQL;
                cmd.ExecuteNonQuery();
                DateTime t = DateTime.Today;
                String time = t.ToString("yyyy-MM-dd");
               // MessageBox.Show(t.ToString("yyyy-MM-dd"));
                sQL = "Insert ReceivedNote values('"+txtName.Text[0]+txtID.Text+"',Cast('"+ time+"'as Date),'"+txtID.Text+"','"+txtRPrice.Text+"','"+txtQuantity.Text+"')";
                SqlCommand sqlCommand = new SqlCommand(sQL, connGeneral);
             
                
                
                
                
                MessageBox.Show("Add product " + txtID.Text + " sucessfully");
                da.Update(dt);
                DataBindProducts();
                txtID.Clear();
                txtName.Clear();
                txtRPrice.Clear();
                txtDPrice.Clear();
                txtQuantity.Clear();

            }
            else
            {
                MessageBox.Show("Please input valid product");
                txtID.Clear();
                txtName.Clear();
                txtRPrice.Clear();
                txtQuantity.Clear();
            }
            

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                selectedrow = dataGridView1.SelectedRows[0];
                selectedID = selectedrow.Cells[0].Value.ToString();
                selectedName = selectedrow.Cells[1].Value.ToString();
                var confirmDialog = MessageBox.Show("Do you want to remove product " + selectedName + " ID: " + selectedID + " from ware house ?", "Confirm", MessageBoxButtons.YesNo);
                if (confirmDialog == DialogResult.Yes)
                {
                    OleDbConnection conn = new OleDbConnection(strConn);
                    conn.Open();
                    String sQL = "delete from Products where ProductID = " + selectedID;
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sQL;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucessfully removed product " + selectedName + " ID: " + selectedID);
                    da.Update(dt);
                    DataBindProducts();
                }
                else if (confirmDialog == DialogResult.No) { }

            } else if (txtID.Text.Length > 0 || txtName.Text.Length > 0)
            {
                
                if (txtID.Text.Length > 0)
                {  
                    for(int i = 0; i < dataGridView1.Rows.Count-1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString().Equals(txtID.Text))
                        {
                            selectedrow = dataGridView1.Rows[i];
                        }
                    }
                    
                }else if(txtName.Text.Length > 0)
                {
                    for(int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString().Equals(txtName.Text))
                        {
                            selectedrow = dataGridView1.Rows[i];
                        }
                    }
                }
                
                selectedID =  selectedrow.Cells[0].Value.ToString();
                selectedName = selectedrow.Cells[1].Value.ToString();
                var confirmDialog = MessageBox.Show("Do you want to remove product " + selectedName + " ID: " + selectedID + " from ware house ?", "Confirm", MessageBoxButtons.YesNo);
                if (confirmDialog == DialogResult.Yes)
                {
                    OleDbConnection conn = new OleDbConnection(strConn);
                    conn.Open();
                    String sQL = "delete from Products where ProductID = " + selectedID;
                    OleDbCommand cmd = conn.CreateCommand();
                    cmd.CommandText = sQL;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sucessfully removed product " + selectedName + " ID: " + selectedID);
                    da.Update(dt);
                    DataBindProducts();
                    txtID.Clear();
                    txtName.Clear();
                }
                else if (confirmDialog == DialogResult.No) { }
                
            }
            else
            {
                MessageBox.Show("Please choose method to remove: \n\n.Choose Product row \n\n.Search for ID or Name in textbox");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void btnUpdateRecevie_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd;
            OleDbDataAdapter da;
            BindingSource bindingSource = null;
            OleDbCommandBuilder oleCommandBuilder = null;
            DataTable dt = new DataTable();
            dataGridViewReceive.DataSource = null;
            dt.Clear();
            OleDbConnection conn = new OleDbConnection(strConn);
            conn.Open();
            String sSQL = "select * from ReceivedNote";
            cmd = conn.CreateCommand();
            cmd.CommandText = sSQL;
            try
            {
                da = new OleDbDataAdapter(sSQL, conn);
                oleCommandBuilder = new OleDbCommandBuilder(da);
                da.Fill(dt);
                bindingSource = new BindingSource { DataSource = dt };
                dataGridViewReceive.DataSource = bindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            int index = dataGridViewOrder.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridViewOrder.Rows[index];
            String deliveryID = row.Cells[0].Value.ToString();
            String date = dateTimePickerorder.Value.ToString("yyyy-MM-dd");
            String aid = row.Cells[1].Value.ToString();
            String pid = row.Cells[2].Value.ToString();
            
            String oprice="";
            for(int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                
                if (dataGridView1.Rows[i].Cells[0].Value.ToString().Equals(pid))
                {
                    oprice = dataGridView1.Rows[i].Cells[4].Value.ToString();
                }
            }
            String quantity = row.Cells[4].Value.ToString();
            SqlCommand cmd = new SqlCommand("insert DeliveryNote values('"+deliveryID+"',cast('"+date+"'as Date),'"+aid+"','"+pid+"','"+oprice+"','"+quantity+"')", connGeneral);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Create Delivery Note Successfully");
        }

        private void btnViewDeliveryNote_Click(object sender, EventArgs e)
        {
            frmDeliveryNote frm = new frmDeliveryNote();
            frm.ShowDialog();
        }

        private void btnChooseMonth_Click(object sender, EventArgs e)
        {
            int revenue = 0;
            int receive = 0;
            int delivery = 0;
         
            String month = txtMonth.Text;
            
            for (int i = 0; i < dataGridViewReceive.Rows.Count-1;i++)
            {
                String date = dataGridViewReceive.Rows[i].Cells[1].Value.ToString();
                String[] s = date.Split('/');
                if (s[0].Equals(month)){
                    //MessageBox.Show("month "+ month+"  s[0]:"+s[0]);
                    int price = Int32.Parse(dataGridViewReceive.Rows[i].Cells[3].Value.ToString());
                    int quantity = Int32.Parse(dataGridViewReceive.Rows[i].Cells[4].Value.ToString());
                    //MessageBox.Show("month " + month + "  s[0]:" + s[0]+" price: "+price+" qua: "+quantity);
                    receive +=price*quantity;
                }
                
            }
            txtReceive.Text = receive.ToString();
            for (int i = 0; i < dataGridViewDelivery.Rows.Count - 1; i++)
            {
                String date = dataGridViewReceive.Rows[i].Cells[1].Value.ToString();
                String[] s = date.Split('/');
                if (s[0].Equals(month))
                {
                    //MessageBox.Show("month "+ month+"  s[0]:"+s[0]);
                    int price = Int32.Parse(dataGridViewDelivery.Rows[i].Cells[4].Value.ToString());
                    int quantity = Int32.Parse(dataGridViewDelivery.Rows[i].Cells[5].Value.ToString());
                    //MessageBox.Show("month " + month + "  s[0]:" + s[0]+" price: "+price+" qua: "+quantity);
                    delivery += price * quantity;
                }

            }
            txtDelivery.Text = delivery.ToString();

            revenue = delivery - receive;
            txtRevenue.Text = revenue.ToString();

            //MessageBox.Show(""+receive+" delivery"+delivery);


        }
    }
}
