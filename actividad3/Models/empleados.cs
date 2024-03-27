namespace actividad3.Models
{
    public class empleados
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int edad { get; set; }
        public string correo_electronico { get; set; }
        public string departamento { get; set; }
        public string cargo { get; set; }
        public decimal salario { get; set; }
        public DateTime fecha_contratacion { get; set; }
    }
}
