using StudentManager.WinForms.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.WinForms.Services
{
    public class StudentApiService
    {
        private readonly HttpClient _httpClient;
        private const string ApiBaseUrl = "https://localhost:7161";
        public StudentApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress=new System.Uri(ApiBaseUrl);
        }
        public async Task<List<StudentDto>> GetStudentsAsync()
        {
            try
            {
                var response = await _httpClient.GetAsync("/api/students");
                response.EnsureSuccessStatusCode();
                return await response.Content.ReadFromJsonAsync<List<StudentDto>>();

            }
            catch (HttpRequestException ex)
            {

                MessageBox.Show($"خطا در برقراری ارتباط با سرور: {ex.Message}", "خطای شبکه", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return new List<StudentDto>();
            }
        }

        public async Task CreateStudentAsync(CreateStudentCommand command)
        {

            var response = await _httpClient.PostAsJsonAsync("/api/students", command);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateStudentAsync(int id, UpdateStudentCommand command)
        {
            var response = await _httpClient.PutAsJsonAsync($"/api/students/{id}", command);
            response.EnsureSuccessStatusCode();
        }
        public async Task DeleteStudentAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"/api/students/{id}");
            response.EnsureSuccessStatusCode();
        }
    }

}
