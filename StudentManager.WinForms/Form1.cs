using StudentManager.WinForms.Models;
using StudentManager.WinForms.Services;

namespace StudentManager.WinForms
{
    public partial class Form1 : Form
    {
        private readonly StudentApiService _apiService;
        private int? _selectedStudentId = null;

        public Form1()
        {
            
            InitializeComponent();
            _apiService = new StudentApiService();
        }

        
        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadStudentsAsync();
        }

        private async Task LoadStudentsAsync()
        {
            var students = await _apiService.GetStudentsAsync();
            studentsDataGridView.DataSource = students;
        }

        private void ClearForm() { fullNameTextBox.Clear(); nationalCodeTextBox.Clear(); birthDatePicker.Value = DateTime.Now; _selectedStudentId = null; studentsDataGridView.ClearSelection(); }

        private void studentsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (studentsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = studentsDataGridView.SelectedRows[0];
                _selectedStudentId = (int)selectedRow.Cells["Id"].Value;
                fullNameTextBox.Text = selectedRow.Cells["FullName"].Value.ToString();
                nationalCodeTextBox.Text = selectedRow.Cells["NationalCode"].Value.ToString();
                birthDatePicker.Value = (DateTime)selectedRow.Cells["BirthDate"].Value;
            }
        }

        private async void addButton_Click(object sender, EventArgs e)
        {
            var command = new CreateStudentCommand { FullName = fullNameTextBox.Text, NationalCode = nationalCodeTextBox.Text, BirthDate = birthDatePicker.Value };
            try
            {
                await _apiService.CreateStudentAsync(command);
                MessageBox.Show("دانشجو با موفقیت اضافه شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                await LoadStudentsAsync();
            }
            catch (Exception ex) { MessageBox.Show($"خطا در افزودن دانشجو: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void updateButton_Click(object sender, EventArgs e)
        {
            if (_selectedStudentId == null) { MessageBox.Show("لطفاً یک دانشجو را برای ویرایش از لیست انتخاب کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            var command = new UpdateStudentCommand { Id = _selectedStudentId.Value, FullName = fullNameTextBox.Text, NationalCode = nationalCodeTextBox.Text, BirthDate = birthDatePicker.Value };
            try
            {
                await _apiService.UpdateStudentAsync(command.Id, command);
                MessageBox.Show("دانشجو با موفقیت به‌روزرسانی شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                await LoadStudentsAsync();
            }
            catch (Exception ex) { MessageBox.Show($"خطا در به‌روزرسانی دانشجو: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (_selectedStudentId == null) { MessageBox.Show("لطفاً یک دانشجو را برای حذف از لیست انتخاب کنید.", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            var confirmResult = MessageBox.Show("آیا از حذف این دانشجو مطمئن هستید؟", "تایید حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    await _apiService.DeleteStudentAsync(_selectedStudentId.Value);
                    MessageBox.Show("دانشجو با موفقیت حذف شد.", "موفقیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                    await LoadStudentsAsync();
                }
                catch (Exception ex) { MessageBox.Show($"خطا در حذف دانشجو: {ex.Message}", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void clearButton_Click(object sender, EventArgs e) { ClearForm(); }
    }
}
