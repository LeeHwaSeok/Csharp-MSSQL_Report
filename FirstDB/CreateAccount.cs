using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //새로 추가한 모듈
using System.Text.RegularExpressions;//
namespace FirstDB
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }
        //파싱을 위한 ID선언
        private int parsedCustomerID;
        private bool IsOrderIDValid()
        {   //텍스트 이름이 공백일경우 메시지 출력
            if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please enter a name");
                return false;
            }
            return true;
        }
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (IsOrderIDValid())
            {
                // 네비게이션에서 설명한 부분은 제외하고 주석처리함.
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand("Sales.uspNewCustomer", connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;

                        //이름을 테이블에 추가합니다.
                        sqlCommand.Parameters.Add(new SqlParameter("@CustomerName", SqlDbType.NVarChar, 40));
                        sqlCommand.Parameters["@CustomerName"].Value = txtCustomerName.Text;

                        //ID를 자동으로 추가합니다. 
                        sqlCommand.Parameters.Add(new SqlParameter("@CustomerID", SqlDbType.Int));
                        sqlCommand.Parameters["@CustomerID"].Direction = ParameterDirection.Output;

                        try
                        {
                            connection.Open();

                            // Run the stored procedure.
                            sqlCommand.ExecuteNonQuery();

                            // Customer ID is an IDENTITY value from the database.
                            this.parsedCustomerID = (int)sqlCommand.Parameters["@CustomerID"].Value;
                            
                            //저장된 아이디를 출력하기 위함
                            this.txtCustomerID.Text = Convert.ToString(parsedCustomerID);
                        }
                        catch
                        {
                            MessageBox.Show("Customer ID was not returned. Account could not be created.");
                        }
                        finally
                        {
                            connection.Close();
                        }
                    }
                }
            }

        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
