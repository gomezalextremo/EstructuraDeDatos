public class Arquitecto
{
    private int codigo;
    private string nombres;
    private string condicionContrato;
    private string especialidad;
    private string tipoActividad;
    private string tipoAfiliacion;

    public Arquitecto(int codigo, string nombres, string condicionContrato, string especialidad,
                        string tipoActividad, string tipoAfiliacion)
    {
        this.codigo = codigo;
        this.nombres = nombres;
        this.condicionContrato = condicionContrato;
        this.especialidad = especialidad;
        this.tipoActividad = tipoActividad;
        this.tipoAfiliacion = tipoAfiliacion;
    }

    // Getters and setters for the attributes

    public int Codigo { get { return codigo; } set { codigo = value; } }
    public string Nombres { get { return nombres; } set { nombres = value; } }
    public string CondicionContrato { get { return condicionContrato; } set { condicionContrato = value; } }
    public string Especialidad { get { return especialidad; } set { especialidad = value; } }
    public string TipoActividad { get { return tipoActividad; } set { tipoActividad = value; } }
    public string TipoAfiliacion { get { return tipoAfiliacion; } set { tipoAfiliacion = value; } }

    // Methods to calculate salary and deductions

    public decimal CalcularSueldoBase()
    {
        if (condicionContrato.Equals("Estable"))
        {
            if (tipoActividad.Equals("Supervisión de Obras"))
            {
                return 4000;
            }
            else if (tipoActividad.Equals("Supervisión de Vías"))
            {
                return 6000;
            }
            else
            {
                throw new Exception("Tipo de actividad no válido");
            }
        }
        else if (condicionContrato.Equals("Contratado"))
        {
            if (tipoActividad.Equals("Supervisión de Obras"))
            {
                return 2000;
            }
            else if (tipoActividad.Equals("Supervisión de Vías"))
            {
                return 4500;
            }
            else
            {
                throw new Exception("Tipo de actividad no válido");
            }
        }
        else
        {
            throw new Exception("Condición de contrato no válida");
        }
    }

    public decimal CalcularBonificacion()
    {
        decimal sueldoBase = CalcularSueldoBase();

        if (especialidad.Equals("Estructuras"))
        {
            return sueldoBase * 0.16m;
        }
        else if (especialidad.Equals("Recursos Hídricos"))
        {
            return sueldoBase * 0.18m;
        }
        else
        {
            throw new Exception("Especialidad no válida");
        }
    }

    public decimal CalcularDescuentos()
    {
        decimal sueldoBase = CalcularSueldoBase();
        decimal afp = sueldoBase * 0.15m;
        decimal snp = sueldoBase * 0.08m;
        return afp + snp;
    }

    public decimal CalcularSueldoNeto()
    {
        return CalcularSueldoBase() + CalcularBonificacion() - Calcular

