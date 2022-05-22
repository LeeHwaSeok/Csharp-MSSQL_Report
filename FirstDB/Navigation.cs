using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;            // DB 사용을 위한 선언
using System.Text.RegularExpressions;   // 정규식 사용을 위한 선언

namespace FirstDB
{
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }
        private int parsedOrderID;  //ID 파싱을 위한 선언
                                    //dbo.Sales -> table -> CustomerID (Key value) 
        private string parsedName;  //Name을 파싱하기 위한 선언 
                                    //dbo.Sales -> table -> CustomerName (nvarchar)

        private void btnGoToAdd_Click(object sender, EventArgs e)
        {
            //회원가입 Form
            Form frm = new NewCustomer();
            frm.Show();
        }

        private bool IsCustomerNameValid()
        {
            // ID가 공백인지 확인
            if (txtCustomerID.Text == "")
            {
                MessageBox.Show("Please specify the Order ID.");
                return false;
            }
            // 이름이 공백인지 확인
            else if (txtCustomerName.Text == "")
            {
                MessageBox.Show("Please specify Name.");
                return false;
            }
            // ID는 INT이면서 KEY값이기에 숫자만 들어가야합니다.
            // Regex.IsMatch 함수는 문자열 정규형 표현식으로 (string input, string pattern) 입력값에 대한 패턴과 매치를 확인하는 변수입니다.
            // 출력은 true or false
            // @"^\D*$" -> 정규식 표현으로 모든 문자가 숫자인지 확인하는 함수입니다.
            else if (Regex.IsMatch(txtCustomerID.Text, @"^\D*$"))
            {
                //따라서 문자가 섞일 경우 숫자만 적으라고 출력합니다.
                MessageBox.Show("Customer ID must contain only numbers.");
                txtCustomerID.Clear();
                return false;
            }
            else
            {
                //이외의 경우는 true기 때문에 id와 name을 테이블에서 찾기위해 파싱에 변수지정을 합니다. 
                parsedOrderID = Int32.Parse(txtCustomerID.Text);
                parsedName = txtCustomerName.Text;
                return true;
            }
        }
        private void btnGoToFillOrCancel_Click(object sender, EventArgs e)
        {   // 파싱된 id와 이름을 갖고와서 데이터베이스 테이블과 비교합니다.
            if (IsCustomerNameValid())
            {   //데이터베이스 서버와 연결하기 위한 함수
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
                {
                    // DB구문에서 SELECT절은 FROM이하 테이블에서 조건에 맞는 결과값을 반환하라는 의미입니다. / *은 모든 테이블을 의미
                    // 즉, Sales.Customer 테이블에서 고객아이디가 동일한 경우 그 테이블만을 반환하라는 의미입니다.
                    const string sql = "SELECT * FROM Sales.Customer WHERE customerID = @customerID";

                    // 테이블과 입력값과의 비교를 위해 SELECT절을 이용 반환된 테이블만 사용합니다. 
                    using (SqlCommand sqlCommand = new SqlCommand(sql, connection))
                    {
                        // 입력된 ID가 테이블의 키와 동일한지 비교를 위한 전처리 단계입니다.
                        sqlCommand.Parameters.Add(new SqlParameter("@customerID", SqlDbType.Int));
                        // 실제 아이디값을 매개변수로 지정해주어 비교합니다
                        sqlCommand.Parameters["@customerID"].Value = parsedOrderID;

                        try
                        {   // C sharp and MS SQL bidirectional connection
                            connection.Open();

                            // 데이터 읽기를 위한 전처리
                            using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                            {
                                // 검색된 데이터 테이블을 보관할 데이터를 만듭니다.
                                DataTable dataTable = new DataTable();

                                // 데이터 테이블에 데이터를 로드합니다
                                dataTable.Load(dataReader);


                                //테이블[0][1]을 사용한 이유는 상단에 SQL을 사용할 때,
                                    //SELECT 절을 사용해서 하나의 테이블 형식으로 데이터를 갖고왔기 때문입니다.
                                    // 데이터는 [[ID],[name]] 이런식으로 저장되어 있습니다.
                                    //아래 if문은 txt이름과 table이름을 비교합니다.
                                if (parsedName == Convert.ToString(dataTable.Rows[0][1]))
                                {   //로그인시 파싱된 아이디를 다음 폼에 같이 넘겨줍니다.
                                    Form frm = new NewCustomer(parsedOrderID);
                                    frm.ShowDialog();
                                }

                                // Close the SqlDataReader.
                                dataReader.Close();
                            }
                        }
                        catch
                        {   //id,name이 형식은 지켯으나 테이블에 해당 값이 존재하지 않는다는 의미입니다.
                            MessageBox.Show("The requested order could not be loaded into the form.");
                        }
                        finally
                        {
                            // Close the connection.
                            connection.Close();
                        }
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Navigation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm = new CreateAccount();
            frm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
