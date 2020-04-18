using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SharpeDiem
{
    public partial class ItemApp : Form
    {
        Controller controller;
        ViewHandler viewHandler;
        ExceptionHandler exceptionHandler;
        string message;
        string itemNbr;
        LoanApp loanApp = new LoanApp();


        public ItemApp()
        {
            InitializeComponent();
            controller = new Controller();
            viewHandler = new ViewHandler();
            exceptionHandler = new ExceptionHandler();
        }

        //Find item button
        private void findItemBtn_Click(object sender, EventArgs e)
        {
            findErrorLbl.Text = null;
            addErrorLbl.Text = null;

            itemNbr = itemNbrTextBox.Text;

            try
            {
                Item item = controller.FindItem(itemNbr);

                String category = item.Category;
                String color = item.Color;
                String condition = item.Condition;
                String description = item.Description;
                String size = item.Size;

                categoryComboBox.Text = category;
                colorComboBox.Text = color;
                conditionComboBox.Text = condition;
                descriptionTextBox.Text = description;
                sizeComboBox.Text = size;
            }
            catch (SqlException sE)
            {
                message = exceptionHandler.ExceptionMessage(sE);
                this.findErrorLbl.ForeColor = System.Drawing.Color.Brown;
                findErrorLbl.Text = message;
            }
            catch (Exception eX)
            {
                message = exceptionHandler.ExceptionMessage(eX);
                this.findErrorLbl.ForeColor = System.Drawing.Color.Brown;
                findErrorLbl.Text = message;
            }
        }

        //Add item button
        private void addItemBtn_Click(object sender, EventArgs e)
        {
            findErrorLbl.Text = null;
            addErrorLbl.Text = null;
            itemNbrTextBox.Text = null;

            try
            {
                String category = categoryComboBox.SelectedItem.ToString();
                String size = sizeComboBox.SelectedItem.ToString();
                String condition = conditionComboBox.SelectedItem.ToString();
                String description = descriptionTextBox.Text;
                String color = colorComboBox.SelectedItem.ToString();
                try
                {
                    string[] parameters = { category, color, condition, description, size };

                    controller.CreateItem(parameters);

                    categoryComboBox.ResetText();
                    colorComboBox.ResetText();
                    conditionComboBox.ResetText();
                    sizeComboBox.ResetText();
                    descriptionTextBox.ResetText();
                    addErrorLbl.Text = "Item added to database";

                }
                catch (SqlException sE)
                {
                    message = exceptionHandler.ExceptionMessage(sE);
                    this.addErrorLbl.ForeColor = System.Drawing.Color.Brown;
                    addErrorLbl.Text = message;

                }
                catch (Exception eX)
                {
                    message = exceptionHandler.ExceptionMessage(eX);
                    this.addErrorLbl.ForeColor = System.Drawing.Color.Brown;
                    addErrorLbl.Text = message;
                }


            } catch
            {
                this.addErrorLbl.ForeColor = System.Drawing.Color.Brown;
                addErrorLbl.Text = "Please enter valid data in all fields";
            }          
        }

        //Update item button
        private void updateItemBtn_Click(object sender, EventArgs e)
        {
            String itemNbr = itemNbrTextBox.Text;
            findErrorLbl.Text = null;
            addErrorLbl.Text = null;

            if(String.IsNullOrEmpty(itemNbr).Equals(false))
            {

                //Checks that all comboboxes are filled
                try
                {

                    String category = categoryComboBox.Text;
                    String size = sizeComboBox.Text;
                    String condition = conditionComboBox.Text;
                    String description = descriptionTextBox.Text;
                    String color = colorComboBox.Text;

                    try
                    {
                        String[] parameters = { itemNbr, category, color, condition, description, size };

                        controller.UpdateItem(itemNbr, parameters);

                        addErrorLbl.Text = "Item " + itemNbr + "is updated";
                        itemNbrTextBox.Text = null;

                        categoryComboBox.ResetText();
                        colorComboBox.ResetText();
                        conditionComboBox.ResetText();
                        sizeComboBox.ResetText();
                        descriptionTextBox.ResetText();
                    }
                    catch (SqlException sE)
                    {
                        message = exceptionHandler.ExceptionMessage(sE);
                        this.addErrorLbl.ForeColor = System.Drawing.Color.Brown;
                        addErrorLbl.Text = message;
                    }
                    catch (Exception eX)
                    {
                        message = exceptionHandler.ExceptionMessage(eX);
                        this.addErrorLbl.ForeColor = System.Drawing.Color.Brown;
                        addErrorLbl.Text = message;
                    }


            }
            catch
            {
                this.addErrorLbl.ForeColor = System.Drawing.Color.Brown;
                addErrorLbl.Text = "Pleae enter valid data in all fields";
            }

            }
            else
            {
                addErrorLbl.Text = "Please serach for item first.";
            }
        }

        //Remove item button
        private void removeItemBtn_Click(object sender, EventArgs e)
        {
            findErrorLbl.Text = null;
            addErrorLbl.Text = null;
            itemNbr = itemNbrTextBox.Text;

                try
                {
                    controller.FindItem(itemNbr);
                    controller.RemoveItem(itemNbr);
                    findErrorLbl.Text = "Item " + itemNbr + " is removed from database";
                    itemNbrTextBox.Text = null;
                }

                catch (SqlException sE)
                {
                    message = exceptionHandler.ExceptionMessage(sE);
                    this.findErrorLbl.ForeColor = System.Drawing.Color.Brown;
                    findErrorLbl.Text = message;
                }
                catch (Exception eX)
                {
                    message = exceptionHandler.ExceptionMessage(eX);
                    this.findErrorLbl.ForeColor = System.Drawing.Color.Brown;
                    findErrorLbl.Text = message;
                }
        }
 
        //Show all items button
        private void showAllBtn_Click(object sender, EventArgs e)
        {
            try
            {
                showAllGridView.ReadOnly = true;
                showAllGridView.DataSource = controller.DisplayItems(null);
            }
            catch(SqlException sE)
            {
                message = exceptionHandler.ExceptionMessage(sE);
                this.showAllErrorLbl.ForeColor = System.Drawing.Color.Brown;
                showAllErrorLbl.Text = message;
            }
            catch(Exception eX)
            {
                message = exceptionHandler.ExceptionMessage(eX);
                this.showAllErrorLbl.ForeColor = System.Drawing.Color.Brown;
                showAllErrorLbl.Text = message;
            }
        }

        private void loanBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            loanApp.ShowDialog();
        }
    }
}