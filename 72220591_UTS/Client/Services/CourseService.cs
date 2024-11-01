using _72220591_UTS.Models;
using System.Net.Http.Json;

namespace _72220591_UTS.Services
{
    public class CourseService
    {
        private readonly HttpClient _httpClient;

        public CourseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Course>> GetCoursesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Course>>("api/courses");
        }

        public async Task<Course> GetCourseAsync(int id)
        {
            return await _httpClient.GetFromJsonAsync<Course>($"api/courses/{id}");
        }

        public async Task CreateCourseAsync(Course course)
        {
            var response = await _httpClient.PostAsJsonAsync("api/courses", course);
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateCourseAsync(Course course)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/courses/{course.Id}", course);
            response.EnsureSuccessStatusCode();
        }

        public async Task DeleteCourseAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"api/courses/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
