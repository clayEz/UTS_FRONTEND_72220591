using System.Collections.Generic;
using System.Threading.Tasks;
using _72220591_UTS.Models;

public interface ICourseService
{
    Task<IEnumerable<Course>> GetCourses();
    Task<Course> GetCourseById(int id);
    Task AddCourse(Course course);
    Task UpdateCourse(Course course);
    Task DeleteCourse(int id);
    Task<IEnumerable<Course>> SearchCourses(string name, int? categoryId);
}
