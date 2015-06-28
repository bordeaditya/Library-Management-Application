using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LibraryApplication.SqlLayer;
using LibraryApplication.LibClass;
using System.Globalization;

namespace LibraryApplication
{
    public partial class MainWindow : Form
    {
        #region Global Variables
        DataLayer dataLayer;

        List<uspGetBookInfo_Result> booksData;
        List<uspGetBookCheckOutInfo_Result> bookCheckOutInfo;
        List<uspGetFinesById_Result> finesRecords;
        uspGetFinesById_Result fineItem;

        Timer timerLabelHide;
        int currentCardNumber = 0, prevCardNumber = 0;
        int checkInCardNumber;
        int finesCardNumber = 0;

        DateTimePicker datePickerDateIn;
        string checkInBookId, checkInBorrowerName;
        string finesBorrowerName = string.Empty;
        bool isReturened = true;
        #endregion
        private Form1 logIn;
        public MainWindow()
        {
            InitializeComponent();
            errorBookSearch.Hide();
            errorBorrower.Hide();
            errorCheckOut.Hide();
            errorCheckIn.Hide();
            notifyCheckIn.Hide();
            notifyFines.Hide();
            notifyUpdateFine.Hide();
            errorFines.Hide();
        }

        #region Book Search Availability
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                booksData = new List<uspGetBookInfo_Result>();
                dataLayer = new DataLayer();
                if (txtBookId.Text.Trim() != string.Empty || txtTitle.Text.Trim() != string.Empty || txtAuthor.Text.Trim() != string.Empty ||
                    txtRole.Text.Trim() != string.Empty)
                {
                    booksData = dataLayer.GetBookSearchData(txtBookId.Text.Trim(), txtTitle.Text.Trim(), txtAuthor.Text.Trim(), txtRole.Text.Trim());

                    if (booksData.Count > 0)
                    {
                        #region Records Available
                        gdbookSerach.DataSource = null;
                        gdbookSerach.AutoGenerateColumns = false;
                        gdbookSerach.DataSource = booksData;
                        gdbookSerach.Show();
                        #endregion
                    }
                    else
                    {
                        #region No Records are Available
                        errorBookSearch.Text = Constants.NoRecordFound;
                        errorBookSearch.Show();
                        #endregion
                    }
                }
                else
                {
                    errorBookSearch.Text = Constants.NoCriteria;
                    errorBookSearch.Show();
                }
            }
            catch (Exception ex)
            {
                errorBookSearch.Text = Constants.ErrorInSearch;
                errorBookSearch.Show();
            }
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            errorBookSearch.Hide();
            gdbookSerach.DataSource = null;
        }

        private void txtBookId_TextChanged(object sender, EventArgs e)
        {
            errorBookSearch.Hide();
            gdbookSerach.DataSource = null;
        }

        private void txtAuthor_TextChanged(object sender, EventArgs e)
        {
            errorBookSearch.Hide();
            gdbookSerach.DataSource = null;
        }

        private void txtRole_TextChanged(object sender, EventArgs e)
        {
            errorBookSearch.Hide();
            gdbookSerach.DataSource = null;
        }

        #region Check Box : Book Search
        private void chkBSBookTitle_CheckedChanged(object sender, EventArgs e)
        {
            errorBookSearch.Hide();
            txtTitle.Text = string.Empty;
            if (!chkBSBookTitle.Checked)
                txtTitle.Enabled = false;
            else
                txtTitle.Enabled = true;
        }

        private void chkBSBookId_CheckedChanged(object sender, EventArgs e)
        {
            errorBookSearch.Hide();
            txtBookId.Text = string.Empty;
            if (!chkBSBookId.Checked)
                txtBookId.Enabled = false;
            else
                txtBookId.Enabled = true;
        }

        private void chkBSAuthor_CheckedChanged(object sender, EventArgs e)
        {
            errorBookSearch.Hide();
            txtAuthor.Text = string.Empty;
            if (!chkBSAuthor.Checked)
                txtAuthor.Enabled = false;
            else
                txtAuthor.Enabled = true;
        }

        private void chkBSRole_CheckedChanged(object sender, EventArgs e)
        {
            errorBookSearch.Hide();
            txtRole.Text = string.Empty;
            if (!chkBSRole.Checked)
                txtRole.Enabled = false;
            else
                txtRole.Enabled = true;
        }
        #endregion

        #endregion

        #region Borrower Management

        private void btnAddBr_Click(object sender, EventArgs e)
        {
            try
            {
                dataLayer = new DataLayer();
                if (txtAddress.Text.Trim() != string.Empty && txtFname.Text.Trim() != string.Empty && txtLname.Text.Trim() != string.Empty)
                {
                    #region verify same Borrower in DB
                    // If it is not Duplicate Entry , Add it to DB
                    if (!(dataLayer.IsDuplicateBorrower(txtFname.Text.Trim(), txtLname.Text.Trim(), txtAddress.Text.Trim())))
                    {
                        int cardNumber = dataLayer.AddNewBorrwoer(txtFname.Text.Trim(), txtLname.Text.Trim(), txtAddress.Text.Trim(), txtPhone.Text.Trim(),txtCity.Text.Trim(),txtState.Text.Trim());
                        txtPhone.Text = string.Empty;
                        txtAddress.Text = string.Empty;
                        txtFname.Text = string.Empty;
                        txtLname.Text = string.Empty;
                        txtState.Text = string.Empty;
                        txtCity.Text = string.Empty;
                        errorBorrower.Text = Constants.NewBRAdded + cardNumber;
                        errorBorrower.Show();
                    }
                    else
                    {
                        errorBorrower.Text = Constants.DuplicateBR;
                        errorBorrower.Show();
                    }
                    #endregion
                }
                else
                {
                    errorBorrower.Text = Constants.RequiredFields;
                    errorBorrower.Show();
                }
            }
            catch (Exception ex)
            {
                errorBorrower.Text = Constants.Error + ex.Message;
            }
        }

        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            errorBorrower.Hide();
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {
            errorBorrower.Hide();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            errorBorrower.Hide();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            errorBorrower.Hide();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            string phone = txtPhone.Text.Trim();
            if (!phone.Contains(Constants.SeperationChar) && phone.Length > Constants.MinimumCharacters)
            {
                if (phone.Length == Constants.MaximumCharacters)
                    txtPhone.Text = string.Format(Constants.Pattern, double.Parse(txtPhone.Text.Trim()));
                else
                {
                    phone = phone.PadRight(Constants.MaximumCharacters, Constants.PaddingChar);
                    txtPhone.Text = string.Format(Constants.Pattern, double.Parse(phone));
                }
            }
        }

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtFname_Leave(object sender, EventArgs e)
        {
            if (txtFname.Text.Trim().Length > Constants.Value0)
                txtFname.Text = Char.ToUpper(txtFname.Text[Constants.Index0]) + txtFname.Text.Substring(Constants.Index1);
        }

        private void txtLname_Leave(object sender, EventArgs e)
        {
            if (txtLname.Text.Trim().Length > Constants.Value0)
                txtLname.Text = Char.ToUpper(txtLname.Text[Constants.Index0]) + txtLname.Text.Substring(Constants.Index1);
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            errorBorrower.Hide();
        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {
            errorBorrower.Hide();
        }

        private void txtState_Leave(object sender, EventArgs e)
        {
            //if (txtState.Text.Trim().Length > Constants.Value0)
            //    txtState.Text = Char.ToUpper(txtState.Text[Constants.Index0]) + txtState.Text.Substring(Constants.Index1);
        }

        private void txtState_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void txtCity_Leave(object sender, EventArgs e)
        {
            if (txtCity.Text.Trim().Length > Constants.Value0)
                txtCity.Text = Char.ToUpper(txtCity.Text[Constants.Index0]) + txtCity.Text.Substring(Constants.Index1);
        }

        private void txtAddress_Leave(object sender, EventArgs e)
        {
            if (txtAddress.Text.Trim().Length > Constants.Value0)
                txtAddress.Text = Char.ToUpper(txtAddress.Text[Constants.Index0]) + txtAddress.Text.Substring(Constants.Index1);
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            txtPhone.Text = string.Empty;
        }
        #endregion

        #region Book Check Out

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                dataLayer = new DataLayer();
                if (txtCheckOutbookId.Text.Trim() != string.Empty && txtCheckOutBranchId.Text.Trim() != string.Empty && txtCheckOutCardNumber.Text.Trim() != string.Empty)
                {

                    int card_no = Convert.ToInt32(txtCheckOutCardNumber.Text.Trim());
                    int branchId = Convert.ToInt32(txtCheckOutBranchId.Text.Trim());
                    #region If Card Number Exists
                    // If Card Number is available in DB
                    if (dataLayer.IsCardNoExists(card_no))
                    {
                        #region If Library Branch have Atleast a copy
                        //Verify given Book Id and Branch Id would have atleast a book copy.
                        if (dataLayer.GetAvailableBooks(txtCheckOutbookId.Text.Trim(), branchId) >= Constants.MinCopies)
                        {
                            #region If Card Number holds < 3 copies
                            // Verify number of issued copies by Card number (Should not be more than 3).
                            if (dataLayer.GetCardNoBookIssuedCount(card_no) < Constants.MaxCopies)
                            {
                                List<uspGetFinesById_Result> fines = new List<uspGetFinesById_Result>();
                                fines = dataLayer.GetFines(card_no, string.Empty, false);
                                if (fines.Count == 0)
                                {
                                    #region Card Holder is not issuing same Book
                                    if (!dataLayer.IsSameCopyCheckedOut(card_no, txtCheckOutbookId.Text.Trim()))
                                    {
                                        #region Borrower not having any Fines Pending
                                        bool bookIssued = dataLayer.AddNewBookLoanAndFines(txtCheckOutbookId.Text.Trim(), branchId, card_no, DateTime.Now.Date, DateTime.Now.Date.AddDays(14));
                                        if (bookIssued)
                                        {
                                            txtCheckOutbookId.Text = string.Empty;
                                            txtCheckOutBranchId.Text = string.Empty;
                                            txtCheckOutCardNumber.Text = string.Empty;
                                            errorCheckOut.Text = Constants.BookIssued + card_no;
                                            errorCheckOut.Show();
                                        }
                                        else
                                        {
                                            errorCheckOut.Text = Constants.ErrorInIssuing;
                                            errorCheckOut.Show();
                                        }
                                        #endregion
                                    }
                                    else // Borrower is checking out same copy
                                    {
                                        errorCheckOut.Text = Constants.SameCopyCheckOut;
                                        errorCheckOut.Show();
                                    }
                                    #endregion
                                }
                                else
                                {
                                    #region Pending Fines
                                    errorCheckOut.Text = Constants.PendingFines;
                                    errorCheckOut.Show();
                                    #endregion
                                }
                            }
                            else // Card number already holds 3 copies 
                            {
                                errorCheckOut.Text = Constants.CardNumber + card_no + Constants.ThreeCopies;
                                errorCheckOut.Show();
                            }
                            #endregion
                        }
                        else // No copies Available
                        {
                            errorCheckOut.Text = Constants.NoBook;
                            errorCheckOut.Show();
                        }
                        #endregion
                    }
                    else // Card Number is not present in DB
                    {
                        errorCheckOut.Text = Constants.NoBorrower;
                        errorCheckOut.Show();
                    }
                    #endregion
                }
                else
                {
                    errorCheckOut.Text = Constants.RequiredFields;
                    errorCheckOut.Show();
                }
            }
            catch (Exception ex)
            {
                errorCheckOut.Text = Constants.Error + ex.Message;
            }
        }

        private void txtCheckOutbookId_TextChanged(object sender, EventArgs e)
        {
            errorCheckOut.Hide();
        }

        private void txtCheckOutBranchId_TextChanged(object sender, EventArgs e)
        {
            errorCheckOut.Hide();
        }

        private void txtCheckOutCardNumber_TextChanged(object sender, EventArgs e)
        {
            errorCheckOut.Hide();
        }

        private void txtCheckOutBranchId_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtCheckOutCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtCheckOutbookId_Leave(object sender, EventArgs e)
        {
            string bookId = txtCheckOutbookId.Text.Trim();
            if (bookId.Length < Constants.MaximumCharacters && bookId.Length > Constants.MinimumCharacters)
            {
                bookId = bookId.PadLeft(Constants.MaximumCharacters, Constants.PaddingChar);
                txtCheckOutbookId.Text = bookId;
            }
        }

        #endregion

        #region Book Check In

        private void btnSearchCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                notifyCheckIn.Hide();
                checkInBookId = txtCheckInBookId.Text.Trim();
                checkInBorrowerName = txtCheckInBRName.Text.Trim();
                if (txtCheckInCardNumber.Text.Trim() != string.Empty)
                    checkInCardNumber = Convert.ToInt32(txtCheckInCardNumber.Text.Trim());
                else
                    checkInCardNumber = 0;

                // If Atleast criteria mentioned in search
                // (CardNumber != 0) => some card number has been entered in the field.
                if (checkInBookId != string.Empty || checkInBorrowerName != string.Empty || checkInCardNumber != 0)
                {
                    GetCheckInGridRecords(checkInBookId, checkInCardNumber, checkInBorrowerName);
                }
                else // No Criteria is entered.
                {
                    errorCheckIn.Text = Constants.NoCriteria;
                    errorCheckIn.Show();
                }
            }
            catch (Exception ex)
            {
                errorCheckIn.Text = Constants.Error + ex.Message;
            }
        }

        /// <summary>
        /// Get the data For Check In Tab Grid
        /// </summary>
        /// <param name="bookId_"></param>
        /// <param name="cardNumber_"></param>
        /// <param name="borrowerName_"></param>
        public void GetCheckInGridRecords(string bookId_, int cardNumber_, string borrowerName_)
        {
            try
            {
                bookCheckOutInfo = new List<uspGetBookCheckOutInfo_Result>();
                dataLayer = new DataLayer();
                bookCheckOutInfo = dataLayer.GetBookCheckOutInfo(checkInBookId, checkInCardNumber, checkInBorrowerName);
                if (bookCheckOutInfo.Count > 0)
                {
                    gdCheckIn.DataSource = null;
                    gdCheckIn.AutoGenerateColumns = false;
                    gdCheckIn.DataSource = bookCheckOutInfo;
                    gdCheckIn.Show();
                }
                else
                {
                    errorCheckIn.Text = Constants.NoRecordFound;
                    errorCheckIn.Show();
                }
            }
            catch (Exception ex)
            {
                // error Occured.
            }
        }

        private void txtCheckInCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void txtCheckInBRName_TextChanged(object sender, EventArgs e)
        {
            errorCheckIn.Hide();
            notifyCheckIn.Hide();
            datePickerDateIn.Hide();
            gdCheckIn.DataSource = null;
            gdCheckIn.AllowUserToAddRows = false;
        }

        private void txtCheckInBookId_TextChanged(object sender, EventArgs e)
        {
            errorCheckIn.Hide();
            notifyCheckIn.Hide();
            datePickerDateIn.Hide();
            gdCheckIn.DataSource = null;
            gdCheckIn.AllowUserToAddRows = false;
        }

        private void txtCheckInCardNumber_TextChanged(object sender, EventArgs e)
        {
            errorCheckIn.Hide();
            notifyCheckIn.Hide();
            datePickerDateIn.Hide();
            gdCheckIn.DataSource = null;
            gdCheckIn.AllowUserToAddRows = false;
        }

        private void txtCheckInCardNumber_Leave(object sender, EventArgs e)
        {
            if (txtCheckInCardNumber.Text.Trim() == string.Empty)
                txtCheckInCardNumber.Text = Constants.DefaultCardNo;
        }

        private void gdCheckIn_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                notifyCheckIn.Hide();
                DateTime dateTimeIn;
                CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
                String dateIn = gdCheckIn.Rows[e.RowIndex].Cells[Constants.DateInIndex].Value.ToString();
                //If DateTime Is Correctly Provided
                if (DateTime.TryParse(dateIn, culture, DateTimeStyles.None, out dateTimeIn))
                {
                    // Do Nothing
                }
                else
                {
                    notifyCheckIn.Text = Constants.IncorrectDate;
                    notifyCheckIn.Show();
                    gdCheckIn.Rows[e.RowIndex].Cells[Constants.DateInIndex].Value = DateTime.Now.Date;
                }

            }
            catch (Exception ex)
            {
                // Error
            }
        }

        private void gdCheckIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SetCheckedItemByCardNumber(gdCheckIn, e, Constants.CheckInCardnumberIndex);
            }
            catch (Exception ex)
            {
                // Exception
            }
        }

        private void gdCheckIn_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                if ((gdCheckIn.Focused) && (gdCheckIn.CurrentCell.ColumnIndex == Constants.DateInIndex))
                {
                    datePickerDateIn.Location = gdCheckIn.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                    datePickerDateIn.Visible = true;
                    datePickerDateIn.Value = DateTime.Today;
                }
                else
                {
                    datePickerDateIn.Visible = false;
                }
            }
            catch (Exception ex)
            {
                // Error
            }
        }

        private void gdCheckIn_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if ((gdCheckIn.Focused) && (gdCheckIn.CurrentCell.ColumnIndex == Constants.DateInIndex))
                {
                    gdCheckIn.CurrentCell.Value = datePickerDateIn.Value.Date;
                    datePickerDateIn.Visible = false;
                }
            }
            catch (Exception ex)
            {
                // Error
            }
        }

        private void gdCheckIn_Scroll(object sender, ScrollEventArgs e)
        {
            //datePickerDateIn.Visible = false;
        }

        private void btnBookCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                dataLayer = new DataLayer();
                string bookId = string.Empty;
                int branchId = 0;
                int cardNumber = 0;
                DateTime dateIn;
                int rowSelectedCount = 0;
                foreach (DataGridViewRow row in gdCheckIn.Rows)
                {
                    // if Check Box is Selected
                    if (Convert.ToBoolean(row.Cells[Constants.CheckBoxIndex].Value))
                    {
                        cardNumber = int.Parse(row.Cells[Constants.CardNoIndex].Value.ToString());
                        bookId = row.Cells[Constants.BookIdInddex].Value.ToString();
                        branchId = int.Parse(row.Cells[Constants.BranchIdInddex].Value.ToString());
                        dateIn = DateTime.Parse(row.Cells[Constants.DateInIndex].Value.ToString());
                        dataLayer.UpdateIssuedCopiesCountDateInDetails(bookId, branchId, cardNumber, dateIn);
                        rowSelectedCount++;
                    }
                }

                // if rows are checked and Check in is successful.
                if (rowSelectedCount > 0 && gdCheckIn.RowCount != rowSelectedCount)
                {
                    GetCheckInGridRecords(checkInBookId, checkInCardNumber, checkInBorrowerName);
                    notifyCheckIn.Text = rowSelectedCount + Constants.CheckInSuccessful;
                    notifyCheckIn.Show();
                }
                else if (gdCheckIn.RowCount == rowSelectedCount)
                {
                    gdCheckIn.DataSource = null;
                    gdCheckIn.AllowUserToAddRows = false;
                    notifyCheckIn.Text = rowSelectedCount + Constants.CheckInSuccessful;
                    notifyCheckIn.Show();
                }
                else
                {
                    notifyCheckIn.Text = Constants.NoReord;
                    notifyCheckIn.Show();
                }

            }
            catch (Exception ex)
            {
                // Error:
            }
        }

        private void btnCancelCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                //Uncheck all check boxed.
                UncheckSelection(gdCheckIn);
            }
            catch (Exception ex)
            {
                // Error
            }
        }

        #region Check Box : Check In
        private void chkBookId_CheckedChanged(object sender, EventArgs e)
        {
            txtCheckInBookId.Text = string.Empty;
            errorCheckIn.Hide();
            if (!chkBookId.Checked)
                txtCheckInBookId.Enabled = false;
            else
                txtCheckInBookId.Enabled = true;
        }

        private void chkBRName_CheckedChanged(object sender, EventArgs e)
        {
            txtCheckInBRName.Text = string.Empty;
            errorCheckIn.Hide();
            if (!chkBRName.Checked)
                txtCheckInBRName.Enabled = false;
            else
                txtCheckInBRName.Enabled = true;
        }

        private void chkCardNo_CheckedChanged(object sender, EventArgs e)
        {
            txtCheckInCardNumber.Text = string.Empty;
            txtCheckInCardNumber.Text = Constants.DefaultCardNo;
            errorCheckIn.Hide();
            if (!chkCardNo.Checked)
                txtCheckInCardNumber.Enabled = false;
            else
                txtCheckInCardNumber.Enabled = true;
        }
        #endregion Book Check In

        #endregion

        #region Fines

        /// <summary>
        /// Get the Fines Grid Records
        /// </summary>
        /// <param name="borrowerName_"></param>
        /// <param name="cardNumber_"></param>
        public void GetFinesGridRecords(string borrowerName_, int cardNumber_,bool isReturned_)
        {
            try
            {
                double totalFine = 0;
                finesRecords = new List<uspGetFinesById_Result>();
                dataLayer = new DataLayer();
                // If filter Criteria is Card Number
                if (rdoFinesCardNumber.Checked)
                {
                    #region Filter Criteria : Card Number
                    // If Card Number is available in DB
                    if (finesCardNumber != 0)
                    {
                        if (dataLayer.IsCardNoExists(finesCardNumber))
                        {
                            finesRecords = dataLayer.GetFines(cardNumber_, borrowerName_, isReturned_);
                            gdFines.DataSource = null;
                            gdFines.AutoGenerateColumns = false;
                            gdFines.DataSource = finesRecords;

                            // Payment is allowed only if Book is Retured
                            if (isReturned_)
                                gdFines.Columns[Constants.FinesCheckBoxIndex].Visible = true;
                            else
                                gdFines.Columns[Constants.FinesCheckBoxIndex].Visible = false;
                        }
                        else // Card No is not present
                        {
                            errorFines.Text = Constants.NoBorrower;
                            errorFines.Show();
                        }
                    }
                    else
                    {
                        errorFines.Text = Constants.CardNumberBlank;
                        errorFines.Show();
                    }
                    #endregion
                }
                else // Criteria is Borrower Name
                {
                    #region Filter Criteria : Borrower Name
                    // Borrower name is not empty
                    if (finesBorrowerName != string.Empty)
                    {
                        finesRecords = dataLayer.GetFines(Constants.DefaultCardNumberValue, borrowerName_, isReturned_);
                        gdFines.DataSource = null;
                        gdFines.AutoGenerateColumns = false;
                        gdFines.DataSource = finesRecords;

                        // Payment is allowed only if Book is Retured
                        if(isReturned_)
                            gdFines.Columns[Constants.FinesCheckBoxIndex].Visible = true;
                        else
                            gdFines.Columns[Constants.FinesCheckBoxIndex].Visible = false;
                    }
                    else
                    {
                        errorFines.Text = Constants.BorrowerNameBlank;
                        errorFines.Show();
                    }
                    #endregion
                }

                // If records are present in DB : Calculate Total Fine
                if (finesRecords.Count > 0)
                {
                    foreach (uspGetFinesById_Result fineRecord in finesRecords)
                        totalFine += Convert.ToDouble(fineRecord.Fine_amount);

                    txtFinesTotal.Text = string.Empty;
                    totalFine = Math.Round(totalFine, 2);
                    txtFinesTotal.Text = Convert.ToString(totalFine);
                }
                else
                {
                    txtFinesTotal.Text = string.Empty;
                    txtFinesTotal.Text = Constants.DefaultCardNo;
                    if (finesBorrowerName != string.Empty || finesCardNumber != 0)
                    {
                        notifyFines.Text = Constants.NoRecordFound;
                        notifyFines.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                // error
            }
        }

        private void btnSearchFines_Click(object sender, EventArgs e)
        {
            try
            {
                notifyFines.Hide();
                finesBorrowerName = txtFinesBorrowerName.Text.Trim();
                string status = (string)cmbStatus.SelectedItem;
                if (string.Equals(status, Constants.Returned))
                    isReturened = true;
                else
                    isReturened = false;

                if (txtFinesCardNumber.Text.Trim() != string.Empty)
                    finesCardNumber = Convert.ToInt32(txtFinesCardNumber.Text.Trim());
                else
                    finesCardNumber = 0;

                // Get Fines Grid Recoreds
                GetFinesGridRecords(finesBorrowerName, finesCardNumber, isReturened);
                
            }
            catch (Exception ex)
            {
                // Exception
            }
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetFinesData();
            string status = (string)cmbStatus.SelectedItem;
            if (string.Equals(status, Constants.Returned))
                isReturened = true;
            else
                isReturened = false;

        }

        private void btnUpdateFines_Click(object sender, EventArgs e)
        {
            try
            {
                dataLayer = new DataLayer();
                dataLayer.UpdateFines();
                notifyUpdateFine.Text = Constants.FinesUpdateSuccessful;
                notifyUpdateFine.Show();
                timerLabelHide.Start();
            }
            catch (Exception ex)
            {
                notifyUpdateFine.Text = Constants.Error;
                notifyUpdateFine.Show();
                System.Threading.Thread.Sleep(10000);
                notifyUpdateFine.Hide();
            }
        }

        private void rdoFinesCardNumber_CheckedChanged(object sender, EventArgs e)
        {
            gdFines.DataSource = null;
            gdFines.AllowUserToAddRows = false;
            txtFinesCardNumber.Text = string.Empty;
            txtFinesTotal.Text = string.Empty;
            txtFinesBorrowerName.Text = string.Empty;
            txtFinesCardNumber.Text = Constants.DefaultCardNo;
            txtFinesTotal.Text = Constants.DefaultCardNo;
            errorFines.Hide();
            notifyFines.Hide();
            if (rdoFinesCardNumber.Checked)
            {
                txtFinesCardNumber.Enabled = true;
                txtFinesBorrowerName.Enabled = false;
            }
            else
            {
                txtFinesCardNumber.Enabled = false;
                txtFinesBorrowerName.Enabled = true;
            }
        }

        private void txtFinesCardNumber_TextChanged(object sender, EventArgs e)
        {
            ResetFinesData();
        }

        private void btnFinesCancel_Click(object sender, EventArgs e)
        {
            try
            {
                //Uncheck all check boxed.
                UncheckSelection(gdFines);
            }
            catch (Exception ex)
            {
                // Error
            }
        }

        private void gdFines_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SetCheckedItemByCardNumber(gdFines, e, Constants.FinesCardnumberIndex);
            }
            catch (Exception ex)
            {
                // Error
            }
        }

        private void txtFinesBorrowerName_TextChanged(object sender, EventArgs e)
        {
            ResetFinesData();
        }

        private void txtFinesCardNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void btnFinesPayment_Click(object sender, EventArgs e)
        {
            try
            {
                //TO DO
                dataLayer = new DataLayer();
                int rowSelectedCount = 0;
                double totalAmount = 0, amount = 0;
                fineItem = new uspGetFinesById_Result();
                finesRecords = new List<uspGetFinesById_Result>();
                foreach (DataGridViewRow row in gdFines.Rows)
                {
                    // if Check Box is Selected
                    if (Convert.ToBoolean(row.Cells[Constants.CheckBoxIndex].Value))
                    {
                        fineItem.Book_id = row.Cells[Constants.FinesBookIdIndex].Value.ToString();
                        fineItem.Branch_id = int.Parse(row.Cells[Constants.FinesBranchIdIndex].Value.ToString());
                        fineItem.Loan_id = int.Parse(row.Cells[Constants.FinesLoanIdIndex].Value.ToString());
                        amount = double.Parse(row.Cells[Constants.FinesFineAmountIndex].Value.ToString());
                        totalAmount += amount;
                        finesRecords.Add(fineItem);
                        rowSelectedCount++;
                    }
                }

                // if rows are checked and Fine Payment is successful.
                if (rowSelectedCount > 0)
                {
                    DialogResult result = MessageBox.Show(Constants.PaymentConfirm + Constants.Dollars + totalAmount, Constants.PaymentConfirmDialog, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        // Payment adding to DB
                        dataLayer.FinePayment(finesRecords);
                        if (rowSelectedCount != gdFines.RowCount)
                        {
                            GetFinesGridRecords(finesBorrowerName, finesCardNumber, isReturened);
                            notifyFines.Text = rowSelectedCount + Constants.PaymentComplete;
                            notifyFines.Show();
                        }
                        else // All rows selected.
                        {
                            gdFines.DataSource = null;
                            gdFines.AllowUserToAddRows = false;
                            notifyFines.Text = rowSelectedCount + Constants.PaymentComplete;
                            notifyFines.Show();
                            txtFinesTotal.Text = string.Empty;
                            txtFinesTotal.Text = Constants.DefaultCardNo;
                        }
                    }
                    else if (result == DialogResult.No)
                    {
                        UncheckSelection(gdFines);
                    }

                }
                else
                {
                    notifyFines.Text = Constants.NoRecordSelected;
                    notifyFines.Show();
                }
            }
            catch (Exception ex)
            {
                // Error.
            }
        }

        /// <summary>
        /// Reset the Related data.
        /// </summary>
        public void ResetFinesData()
        {
            txtFinesTotal.Text = string.Empty;
            txtFinesTotal.Text = Constants.DefaultCardNo;

            errorFines.Hide();
            notifyFines.Hide();
            gdFines.DataSource = null;
            gdFines.AllowUserToAddRows = false;
        }
        #endregion

        #region Common Events And Methods

        private void MainWindow_Load(object sender, EventArgs e)
        {
            datePickerDateIn = new DateTimePicker();
            datePickerDateIn.Format = DateTimePickerFormat.Short;
            datePickerDateIn.Visible = false;
            datePickerDateIn.Width = Constants.DateInWidth;
            gdCheckIn.Controls.Add(datePickerDateIn);
            datePickerDateIn.ValueChanged += new EventHandler(datePickerDateIn_ValueChanged);
            timerLabelHide = new Timer();
            timerLabelHide.Interval = Constants.DisplayTime;
            timerLabelHide.Tick += new EventHandler(timerLabelHide_Tick);
            cmbStatus.SelectedIndex = Constants.CheckBoxIndex;
            gdFines.DataSource = null;
            gdFines.AllowUserToAddRows = false;
            gdCheckIn.DataSource = null;
            gdCheckIn.AllowUserToAddRows = false;
            gdbookSerach.DataSource = null;
            gdbookSerach.AllowUserToAddRows = false;
            pdfManual.src = Constants.ManualPage;
        }

        void timerLabelHide_Tick(object sender, EventArgs e)
        {
            notifyUpdateFine.Hide();
            timerLabelHide.Stop();
        }

        private void datePickerDateIn_ValueChanged(object sender, EventArgs e)
        {
            gdCheckIn.CurrentCell.Value = datePickerDateIn.Text;
        }


        /// <summary>
        /// Uncheck All selected rows
        /// </summary>
        /// <param name="grid"></param>
        private void UncheckSelection(DataGridView gridView)
        {
            //Uncheck all check boxed.
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[Constants.CheckBoxIndex].Value))
                    row.Cells[Constants.CheckBoxIndex].Value = false;
            }
        }

        private void tabMainMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCardNumber = 0;
            prevCardNumber = 0;
            cmbStatus.SelectedIndex = Constants.CheckBoxIndex;
            ClearAllResults();
        }

        private void tabLoans_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentCardNumber = 0;
            prevCardNumber = 0;
            cmbStatus.SelectedIndex = Constants.CheckBoxIndex;
            ClearAllResults();
        }

        /// <summary>
        /// To Keep selected checkboxes of grid of having same Card Number
        /// When New Card Number gets selected,previous all selections will be removed.
        /// </summary>
        /// <param name="gridView"></param>
        /// <param name="e"></param>
        /// <param name="CardNoIndex"></param>
        private void SetCheckedItemByCardNumber(DataGridView gridView, DataGridViewCellEventArgs e, string cardNoIndex)
        {
            try
            {
                currentCardNumber = int.Parse(gridView.Rows[e.RowIndex].Cells[cardNoIndex].Value.ToString());
                if (prevCardNumber == 0)
                {
                    #region First Selection
                    prevCardNumber = int.Parse(gridView.Rows[e.RowIndex].Cells[cardNoIndex].Value.ToString());
                    #endregion
                }
                else
                {
                    #region After First Selection
                    if (prevCardNumber == currentCardNumber)
                    {
                        // Do Nothing
                    }
                    else
                    {
                        prevCardNumber = currentCardNumber;
                        foreach (DataGridViewRow row in gridView.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[Constants.CheckBoxIndex].Value))
                                row.Cells[Constants.CheckBoxIndex].Value = false;
                        }

                    }
                    #endregion
                }
            }
            catch (Exception ex)
            {
                // error
            }
        }

        private void ClearAllResults()
        {
            #region Book Search
            txtBookId.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtTitle.Text = string.Empty;
            txtRole.Text = string.Empty;
            errorBookSearch.Hide();
            gdbookSerach.DataSource = null;
            #endregion

            #region Borrower Management
            txtFname.Text = string.Empty;
            txtLname.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtState.Text = string.Empty;
            txtCity.Text = string.Empty;
            errorBorrower.Hide();
            #endregion

            #region Check In
            txtCheckInBookId.Text = string.Empty;
            txtCheckInBRName.Text = string.Empty;
            txtCheckInCardNumber.Text = string.Empty;
            txtCheckInCardNumber.Text = Constants.DefaultCardNo;
            errorCheckIn.Hide();
            notifyCheckIn.Hide();
            gdCheckIn.DataSource = null;
            gdCheckIn.AllowUserToAddRows = false;
            #endregion

            #region Check Out
            txtCheckOutbookId.Text = string.Empty;
            txtCheckOutBranchId.Text = string.Empty;
            txtCheckOutCardNumber.Text = string.Empty;
            errorCheckOut.Hide();
            #endregion

            #region Fines
            txtFinesBorrowerName.Text = string.Empty;
            txtFinesCardNumber.Text = string.Empty;
            txtFinesCardNumber.Text = Constants.DefaultCardNo;
            errorFines.Hide();
            gdFines.DataSource = null;
            gdFines.AllowUserToAddRows = false;
            notifyFines.Hide();
            notifyUpdateFine.Hide();
            #endregion
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            logIn = new Form1();
            this.Hide();
            logIn.Show();
        }
        #endregion

    }
}
