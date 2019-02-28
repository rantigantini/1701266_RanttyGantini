using pv03_nim_nama.Model;
using pv03_nim_nama.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pv03_nim_nama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TodoRepository todo = new TodoRepository();
            tbNim.Enabled = false;

            string nim = tbNim.Text;

            btnAdd.Enabled = true;
            submitNim.Enabled = false;

            dataGridView2.DataSource = todo.getByNim(nim);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Todo temp = new Todo();

            temp.NimMhs = tbNim.Text;
            temp.Nama = tbNama.Text;
            temp.Kategori = tbKategori.Text;

            TodoRepository todo = new TodoRepository();

            todo.addTodo(temp);

            string nim = tbNim.Text;

            dataGridView2.DataSource = todo.getByNim(nim);

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Todo temp = new Todo();

            temp.Id = Convert.ToInt16(tbId.Text) ;

            TodoRepository todo = new TodoRepository();

            todo.deleteTodo(temp);

            string nim = tbNim.Text;

            dataGridView2.DataSource = todo.getByNim(nim);
        }

        private void tbIdu_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbnamak_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbkate_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Todo temp = new Todo();

            temp.Id = Convert.ToInt16(tbIdu.Text);
            temp.NimMhs = tbNim.Text;
            temp.Nama = tbnamak.Text;
            temp.Kategori = tbkate.Text;

            TodoRepository todo = new TodoRepository();

            todo.updateTodo(temp);

            string nim = tbNim.Text;

            dataGridView2.DataSource = todo.getByNim(nim);
        }
    }
}
