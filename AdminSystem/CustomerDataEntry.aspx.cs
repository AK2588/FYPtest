using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            if (CustomerId != -1)
            {
                DisplayCustomer();
            }
        }
       
    }

    void DisplayCustomer()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ThisCustomer.Find(CustomerId);
        txtCustomerNo.Text = Customers.ThisCustomer.ID.ToString();
        txtCustomerUsername.Text = Customers.ThisCustomer.Username;
        txtCustomerPassword.Text = Customers.ThisCustomer.Password;
        txtCustomerAddress.Text = Customers.ThisCustomer.Address;
        txtCustomerDateAdded.Text = Customers.ThisCustomer.DateAdded.ToString();
        cbxCustomerActive.Checked = Customers.ThisCustomer.Active;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        // Create a new instance of clsCustomer
        clsCustomer Customer = new clsCustomer();
        // Capture the customer values
        
        string CustomerUsername = txtCustomerUsername.Text;
        string CustomerPassword = txtCustomerPassword.Text;
        string CustomerAddress = txtCustomerAddress.Text;
        string CustomerValid = cbxCustomerActive.Checked.ToString();
        string CustomerDateAdded = txtCustomerDateAdded.Text;
        string Error = "";
        Error = Customer.Valid("1", CustomerUsername, CustomerPassword, CustomerAddress, CustomerDateAdded, CustomerValid);
        if (Error == "")
        {
            Customer.ID = CustomerId;
            Customer.Username = CustomerUsername;
            Customer.Password = CustomerPassword;
            Customer.Address = CustomerAddress;
            Customer.Active = Convert.ToBoolean(CustomerValid);
            Customer.DateAdded = Convert.ToDateTime(CustomerDateAdded);

            clsCustomerCollection CustomerList = new clsCustomerCollection();
           
            if (CustomerId == -1)
            {
                CustomerList.ThisCustomer = Customer;
                CustomerList.Add();
            } else
            {
                CustomerList.ThisCustomer.Find(CustomerId);
                CustomerList.ThisCustomer = Customer;
                CustomerList.Update();
            }
            
           
            Response.Redirect("CustomerList.aspx");
        } else
        {
            lblError.Text = Error;
        }
    
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        // Create an instance of customer class
        clsCustomer ACustomer = new clsCustomer();
        // variable to store primray key
        Int32 CustomerID;
        // var to store result of find oper
        Boolean Found = false;
        // Get primary key entered

        try
        {
            CustomerID = Convert.ToInt32(txtCustomerNo.Text);
        } catch (FormatException ex)
        {
            return;
        }
        
        // find record
        Found = ACustomer.Find(CustomerID);
        // if found
        if (Found == true)
        {
            // display values o fproperties in form
            txtCustomerUsername.Text = ACustomer.Username;
            txtCustomerPassword.Text = ACustomer.Password;
            txtCustomerAddress.Text = ACustomer.Address;
            txtCustomerDateAdded.Text = ACustomer.DateAdded.ToString();
            cbxCustomerActive.Checked = ACustomer.Active;
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("CustomerList.aspx");
    }
}