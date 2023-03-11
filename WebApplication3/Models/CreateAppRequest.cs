
using System.ComponentModel.DataAnnotations;
using WebApplication3.Persistence.Models;

namespace WebApplication3.Models
{
    public class CreateAppRequest
    {
        public int Id { get; set; }
        [RegularExpression(@"^[\s�-��-���a-zA-Z$&+,:;=?@#|""��'<>.-^*()%!_-]+$", ErrorMessage = "������� ������������ �������")]
        [Required(ErrorMessage = "������� ��������")]
        public string Name { get; set; }
        [Required(ErrorMessage = "������� ������")]
        public string Version { get; set; }
        [RegularExpression(@"^[\s�-��-���a-zA-Z$&+,:;=?@#|""��'<>.-^*()%!_-]+$", ErrorMessage = "������� ������������ �������")]
        [Required(ErrorMessage = "������� ��������")]
        public string Description { get; set; }
        [Required(ErrorMessage = "������� ������")]
        public int GroupId { get; set; }
        [Required(ErrorMessage = "������� ��� ����������")]
        public int GroupTypeId { get; set; }
        [Required(ErrorMessage = "�������� �������")]
        public IFormFile Logo { get; set; }
        [Required(ErrorMessage = "�������� ���������")]
        public IFormFileCollection Screenshots { get; set; }
        [Required(ErrorMessage = "������� ����")]
        public DateTimeOffset? CreatedDate { get; set; }
        [Required(ErrorMessage = "�������� ����")]
        public IFormFile Apk { get; set; }
    }
}