using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace OSFENIXGDI2.Entidades
{

    class Producto
{
    private int id_prod;
    private string nombre;
    private string descrip_prod;
    private string composicion;
    private string fechafabricacion;

public Producto(int id_prod, string nombre, string descrip_prod, string composicion, string fechafabricacion)
    {
        this.id_prod = id_prod;
        this.nombre = nombre;
        this.descrip_prod = descrip_prod;
        this.composicion = composicion;
        this.fechafabricacion = fechafabricacion;
    
}


public Producto()
    {
    }
    public int Id_prod { get => id_prod; set => id_prod = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Descrip_prod { get => descrip_prod; set => descrip_prod = value; }
    public string Composicion { get => composicion; set => composicion = value; }
    public string Fechafabricacion { get => fechafabricacion ; set => fechafabricacion = value; }

}

}


