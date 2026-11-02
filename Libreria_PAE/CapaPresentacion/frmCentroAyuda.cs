using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmCentroAyuda : Form
    {
        public frmCentroAyuda()
        {
            InitializeComponent();
        }

        // 1. Botón Guía del sistema
        private void button1_Click(object sender, EventArgs e)
        {
            lblTituloAyuda.Text = "Primeros pasos";
            lblContenidoAyuda.Text =
                "• Inicia sesión con tu usuario y contraseña asignados.\n\n" +
                "• Accede a los diferentes módulos desde el menú lateral.\n\n" +
                "• Registra categorías, proveedores y productos antes de vender.\n\n" +
                "• Recuerda cerrar tu sesión al terminar el turno.";
        }

        // 2. Botón Preguntas frecuentes
        private void button2_Click(object sender, EventArgs e)
        {
            lblTituloAyuda.Text = "Preguntas frecuentes";
            lblContenidoAyuda.Text =
                "¿Por qué no puedo eliminar una categoría?\n" +
                "  ↳ Puede tener productos o registros asociados actualmente.\n\n" +
                "¿Qué hago si no aparecen datos en la tabla?\n" +
                "  ↳ Revisa el filtro de búsqueda o limpia la caja de texto.\n\n" +
                "¿Cómo cierro sesión adecuadamente?\n" +
                "  ↳ Haz clic en el botón 'Cerrar sesión' en la ventana principal.";
        }

        // 3. Botón Clientes
        private void button3_Click(object sender, EventArgs e)
        {
            lblTituloAyuda.Text = "Clientes";
            lblContenidoAyuda.Text =
                "• Registrar: Completa nombre, apellido y teléfono.\n\n" +
                "• Consultar: Busca rápidamente por nombre o apellido.\n\n" +
                "• Modificar: Selecciona un cliente del listado y guarda los cambios.\n\n" +
                "• Dar de baja: Selecciona el registro y confirma la acción.\n\n" +
                "* Consumidor General es un registro protegido del sistema.";
        }

        // 4. Botón Categorías
        private void button4_Click(object sender, EventArgs e)
        {
            lblTituloAyuda.Text = "Categorías y subcategorías";
            lblContenidoAyuda.Text =
                "• Crea una categoría con su respectivo nombre y descripción.\n\n" +
                "• Asigna cada subcategoría a su categoría correspondiente.\n\n" +
                "• Selecciona un registro existente en la tabla para modificarlo.\n\n" +
                "* Nota: No se pueden eliminar categorías que tengan registros relacionados.";
        }

        // 5. Botón Inventario
        private void button5_Click(object sender, EventArgs e)
        {
            lblTituloAyuda.Text = "Inventario y Productos";
            lblContenidoAyuda.Text =
                "• Completa los datos generales y especificaciones del producto.\n\n" +
                "• Selecciona su categoría y subcategoría en los selectores.\n\n" +
                "• Indica con precisión el precio de compra y el precio de venta.\n\n" +
                "• Consulta existencias disponibles y monitorea el stock mínimo.";
        }

        // 6. Botón Ventas
        private void button6_Click(object sender, EventArgs e)
        {
            lblTituloAyuda.Text = "Compras y ventas";
            lblContenidoAyuda.Text =
                "• Compras: Selecciona el proveedor y agrega los productos al detalle.\n\n" +
                "• Ventas: Selecciona el cliente y agrega los productos a la factura.\n\n" +
                "* Revisa detalladamente las cantidades y totales antes de confirmar.";
        }

        // 7. Botón Usuarios
        private void button7_Click(object sender, EventArgs e)
        {
            lblTituloAyuda.Text = "Usuarios y roles (Solo para el administrador)";
            lblContenidoAyuda.Text =
                "• Registra los datos del personal autorizado.\n\n" +
                "• Asigna un nombre de usuario y su rol correspondiente.\n\n" +
                "• Consulta el estado y nivel de acceso de cada cuenta.\n\n" +
                "• Desactiva el acceso al sistema cuando el personal finalice labores.";
        }

        // 8. Botón Proveedores
        private void button8_Click(object sender, EventArgs e)
        {
            lblTituloAyuda.Text = "Proveedores";
            lblContenidoAyuda.Text =
                "• Registra la información corporativa y de contacto del proveedor.\n\n" +
                "• Busca y selecciona un registro en el listado para gestionarlo.\n\n" +
                "• Actualiza sus datos de contacto cuando sea necesario.\n\n" +
                "• Guarda los cambios realizados para mantener la base al día.";
        }

        // 9. Botón Cerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTituloAyuda_Click(object sender, EventArgs e)
        {

        }

        private void lblContenidoAyuda_Click(object sender, EventArgs e)
        {

        }

        private void lblContenidoAyuda_Click_1(object sender, EventArgs e)
        {

        }
    }
}