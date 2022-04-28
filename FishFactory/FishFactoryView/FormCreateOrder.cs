using FishFactoryContracts.BindingModels;
using FishFactoryContracts.BusinessLogicsContracts;
using FishFactoryContracts.ViewModels;
using System;
using System.Windows.Forms;


namespace FishFactoryView
{
    public partial class FormCreateOrder : Form
    {

        private readonly ICannedLogic _logicP;
        private readonly IOrderLogic _logicO;
        private readonly IClientLogic _logicC;
        public FormCreateOrder(ICannedLogic logicP, IOrderLogic logicO, IClientLogic logicC)
        {
            InitializeComponent();
            _logicP = logicP;
            _logicO = logicO;
            _logicC = logicC;
        }
        private void FormCreateOrder_Load(object sender, EventArgs e)
        {
            try
            {

                // продумать логику
                var listP = _logicP.Read(null);
                foreach (var travel in listP)
                {
                    Canned_comboBox.DisplayMember = "CannedName";
                    Canned_comboBox.ValueMember = "Id";
                    Canned_comboBox.DataSource = listP;
                    Canned_comboBox.SelectedItem = null;
                }

                var listC = _logicC.Read(null);
                foreach (var client in listC)
                {
                    Client_comboBox.DataSource = listC;
                    Client_comboBox.DisplayMember = "ClientFIO";
                    Client_comboBox.ValueMember = "Id";
                    Client_comboBox.SelectedItem = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка create order load ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CalcSum()
        {
            if (Canned_comboBox.SelectedValue != null &&
           !string.IsNullOrEmpty(Amount_textBox.Text))
            {
                try
                {
                    int id = Convert.ToInt32(Canned_comboBox.SelectedValue);
                    CannedViewModel canned = _logicP.Read(new CannedBindingModel
                    {
                        Id
                    = id
                    })?[0];
                    int count = Convert.ToInt32(Amount_textBox.Text);
                    Summ_textBox.Text = (count * canned?.Price ?? 0).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
        private void TextBoxCount_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
        private void ComboBoxCanned_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSum();
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Amount_textBox.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Canned_comboBox.SelectedValue == null)
            {
                MessageBox.Show("Выберите изделие", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            if (Client_comboBox.SelectedValue == null)
            {
                MessageBox.Show("Выберите клиента", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logicO.CreateOrder(new CreateOrderBindingModel
                {
                    CannedId = Convert.ToInt32(Canned_comboBox.SelectedValue),
                    ClientId = Convert.ToInt32(Client_comboBox.SelectedValue),
                    Count = Convert.ToInt32(Amount_textBox.Text),
                    Sum = Convert.ToDecimal(Summ_textBox.Text)
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }
        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        private void textBoxCount_TextChanged(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void comboBoxCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcSum();
        }

        private void Summ_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
