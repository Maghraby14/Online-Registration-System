using BlazorApp1.HttpClientServices;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System;
using ClassLibrary1;
using System.Collections.Generic;
using static System.Net.WebRequestMethods;
namespace BlazorApp1.DataConsumers
{
    public class StudentConsumer
    {
        private readonly APIService _aPIService;

        public StudentConsumer(APIService aPIService)
        {
            _aPIService = aPIService;
        }

        // Method to get a student by ID and password
        public async Task<StudentViewModel> GetStudent(int id, int password)
        {
            try
            {
                // Construct the API endpoint URL
                
                var url = $"{_aPIService.GetBaseUrl()}api/students/{id}?password={password}";

                // Send a GET request to retrieve the student
                var response = await _aPIService.httpClient.GetAsync($"https://localhost:44375/api/students/{id}?password={password}");
                
                // Ensure successful response
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize response to Student object
                    return await response.Content.ReadFromJsonAsync<StudentViewModel>();
                }
                else
                {
                    // Handle error (e.g., student not found or unauthorized)
                    throw new Exception($"Failed to retrieve student. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log or rethrow as needed)
                throw new Exception($"An error occurred while getting the student: {ex.Message}");
            }
        }
        public async Task<IEnumerable<ScheduleGroupViewModel>> GetAvailableCourses(int studentId)
        {
            try
            {
                // Construct the API endpoint URL
                var url = $"https://localhost:44375/api/students/{studentId}/availableCourses";

                // Send a GET request to retrieve the available courses
                var response = await _aPIService.httpClient.GetAsync(url);

                // Ensure successful response
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize response to List of ScheduleGroupViewModel objects
                    return await response.Content.ReadFromJsonAsync<IEnumerable<ScheduleGroupViewModel>>();
                }
                else
                {
                    // Handle error (e.g., no courses found)
                    throw new Exception($"Failed to retrieve available courses. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log or rethrow as needed)
                throw new Exception($"An error occurred while getting available courses: {ex.Message}");
            }
        }
        public async Task<IEnumerable<RegisteredCourseDto>> GetRegisteredCourses(int studentId)
        {
            try
            {
                // Construct the API endpoint URL
                var url = $"https://localhost:44375/api/students/{studentId}/registered";

                // Send a GET request to retrieve the available courses
                var response = await _aPIService.httpClient.GetAsync(url);

                // Ensure successful response
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize response to List of ScheduleGroupViewModel objects
                    return await response.Content.ReadFromJsonAsync<IEnumerable<RegisteredCourseDto>>();
                }
                else
                {
                    // Handle error (e.g., no courses found)
                    throw new Exception($"Failed to retrieve available courses. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log or rethrow as needed)
                throw new Exception($"An error occurred while getting available courses: {ex.Message}");
            }
        }
        public async Task<IEnumerable<addSchedule>> PostRegisteredCourses(IEnumerable<addSchedule> studentsReg)
        {
            try
            {
                // Construct the API endpoint URL
                var url = $"https://localhost:44375/api/students/Registered";

                // Send a POST request with the studentsReg data to register the students for courses
                var response = await _aPIService.httpClient.PostAsJsonAsync(url, studentsReg);

                // Ensure successful response
                if (response.IsSuccessStatusCode)
                {
                    // Deserialize response to List of RegisteredDto objects (only studentId, courseId, and groupId)
                    return await response.Content.ReadFromJsonAsync<IEnumerable<addSchedule>>();
                }
                else
                {
                    // Handle error (e.g., failed registration)
                    throw new Exception($"Failed to register students. Status code: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions (log or rethrow as needed)
                throw new Exception($"An error occurred while registering students: {ex.Message}");
            }
        }

    }

}
