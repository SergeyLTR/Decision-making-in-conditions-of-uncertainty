using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Decision_making_in_conditions_of_uncertainty
{
    public partial class App : Form
    {
        public Int32 MaxRows { get; set; }

        public App()
        {
            MaxRows = 10;

            InitializeComponent();
            dataGridView.Rows[dataGridView.Rows.Count - 1].HeaderCell.Value = "a1";
            dataGridView.UserAddedRow += dataGridView_RowCountChanged;
            dataGridView.UserAddedRow += dataGridView_RowCountChanged;
        }

        private void dataGridView_RowCountChanged(object sender, EventArgs e)
        {
            CheckRowCount();
            dataGridView.Rows[dataGridView.Rows.Count - 1].HeaderCell.Value = string.Format("a{0}", dataGridView.Rows.Count);
        }

        private void CheckRowCount()
        {
            if (dataGridView.Rows != null && dataGridView.Rows.Count > MaxRows)
            {
                dataGridView.AllowUserToAddRows = false;
            }
            else if (!dataGridView.AllowUserToDeleteRows)
            {
                dataGridView.AllowUserToResizeRows = true;
            }
        }

        private struct Cell
        {
            public int index;
            public double value;
        }

        private Cell findMinInRow(DataGridViewRow row, Cell cell)
        {
            cell.value = Convert.ToDouble(row.Cells[0].Value);
            cell.index = row.Cells[0].RowIndex + 1;
            foreach (DataGridViewCell selectedCell in row.Cells)
            {
                if (selectedCell.Value != null)
                    if (Convert.ToDouble(selectedCell.Value) < cell.value)
                    {
                        cell.value = Convert.ToDouble(selectedCell.Value);
                        cell.index = selectedCell.RowIndex + 1;
                    }
            }
            return cell;
        }

        private Cell findMaxInRow(DataGridViewRow row, Cell cell)
        {
            cell.value = Convert.ToDouble(row.Cells[0].Value);
            cell.index = row.Cells[0].RowIndex + 1;
            foreach (DataGridViewCell selectedCell in row.Cells)
            {
                if (selectedCell.Value != null)
                    if (Convert.ToDouble(selectedCell.Value) > cell.value)
                    {
                        cell.value = Convert.ToDouble(selectedCell.Value);
                        cell.index = selectedCell.RowIndex + 1;
                    }
            }
            return cell;
        }

        private Cell findMax(Cell cell, List<Cell> CalcOfCells)
        {
            cell.value = CalcOfCells.First().value;
            cell.index = CalcOfCells.First().index;
            foreach (Cell c in CalcOfCells)
            {
                if (c.value > cell.value)
                {
                    cell.value = c.value;
                    cell.index = c.index;
                }
            }
            return cell;
        }

        private Cell findMin(Cell cell, List<Cell> CalcOfCells)
        {
            cell.value = CalcOfCells.First().value;
            cell.index = CalcOfCells.First().index;
            foreach (Cell c in CalcOfCells)
            {
                if (c.value < cell.value)
                {
                    cell.value = c.value;
                    cell.index = c.index;
                }
            }
            return cell;
        }

        private bool ValidateAlfa()
        {
            try
            {
                double x = Convert.ToDouble(Alfa.Text);
                return x >= 0 && x <= 1;
            }
            catch { return false; };
        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            Cell c = new Cell
            {
                value = 0,
                index = 0
            };
            if (checkedListBox.GetItemChecked(0))
            {
                List<Cell> avgOfCells = new List<Cell>();
                int count = 0;

                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        c.index = cell.RowIndex + 1;
                        if (cell.Value != null)
                        {
                            c.value += Convert.ToDouble(cell.Value);
                            count++;
                        }
                    }
                    c.value /= count;
                    avgOfCells.Add(c);
                    c.value = 0;
                    count = 0;
                }
                foreach (Cell d in avgOfCells)
                {
                    Console.WriteLine(d.value);
                }
                if (radioButtonWin.Checked)
                    c = findMax(c, avgOfCells);
                else
                    c = findMin(c, avgOfCells);
                LaplasСriteria.Text = c.value.ToString();
                LaplasALT.Text = c.index.ToString();
                c.value = 0;
                c.index = 0;
            }

            if (checkedListBox.GetItemChecked(1))
            {
                List<Cell> listVald = new List<Cell>();
                if (radioButtonWin.Checked)
                {
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        listVald.Add(findMinInRow(row, c));
                    }
                    c = findMax(c, listVald);
                }
                else
                {
                    foreach (DataGridViewRow row in dataGridView.SelectedRows)
                    {
                        listVald.Add(findMaxInRow(row, c));
                    }
                    c = findMin(c, listVald);
                }
                ValdKrit.Text = c.value.ToString();
                ValdAlt.Text = c.index.ToString();
                c.value = 0;
                c.value = 0;
            }
            if (checkedListBox.GetItemChecked(2) && dataGridView.SelectedRows.Count > 0)
            {
                double[] minInColumn = new double[10];
                double[] maxInColumn = new double[10];
                double[,] matrix = new double[10, 10];
                int len = dataGridView.SelectedRows.Count;
                List<Cell> maxInRow = new List<Cell>();
                List<Cell> minInRow = new List<Cell>();

                if (radioButtonLose.Checked)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        minInColumn[i] = Convert.ToDouble(dataGridView[i, 0].Value);
                        for (int j = 0; j < len; j++)
                        {
                            if (dataGridView[i, j].Value != null)
                            {
                                if (Convert.ToDouble(dataGridView[i, j].Value) < minInColumn[i])
                                {
                                    minInColumn[i] = Convert.ToDouble(dataGridView[i, j].Value);
                                }
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < len; j++)
                        {
                            if (dataGridView[i, j].Value != null)
                            {
                                matrix[i, j] = Convert.ToDouble(dataGridView[i, j].Value) - minInColumn[i];
                            }
                        }
                    }
                    for (int j = 0; j < len; j++)
                    {
                        c.value = matrix[0, j];
                        c.index = j + 1;
                        for (int i = 0; i < 10; i++)
                        {
                            if (matrix[i, j] > c.value)
                            {
                                c.value = matrix[i, j];
                                c.index = j + 1;
                            }
                        }
                        maxInRow.Add(c);
                    }
                    c = findMin(c, maxInRow);

                    SKrit.Text = c.value.ToString();
                    SAlt.Text = c.index.ToString();
                    c.value = 0;
                    c.index = 0;
                }
                else
                {
                    for (int i = 0; i < 10; i++)
                    {
                        maxInColumn[i] = Convert.ToDouble(dataGridView[i, 0].Value);
                        for (int j = 0; j < len; j++)
                        {
                            if (dataGridView[i, j].Value != null)
                            {
                                if (Convert.ToDouble(dataGridView[i, j].Value) > maxInColumn[i])
                                {
                                    maxInColumn[i] = Convert.ToDouble(dataGridView[i, j].Value);
                                }
                            }
                        }
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < len; j++)
                        {
                            if (dataGridView[i, j].Value != null)
                            {
                                matrix[i, j] = maxInColumn[i] - Convert.ToDouble(dataGridView[i, j].Value);
                            }
                        }
                    }
                    for (int j = 0; j < len; j++)
                    {
                        c.value = double.MaxValue;
                        for (int i = 0; i < 10; i++)
                        {
                            if (matrix[i, j] != 0)
                                if (matrix[i, j] < c.value)
                                {
                                    c.value = matrix[i, j];
                                    c.index = j + 1;
                                }
                        }
                        minInRow.Add(c);
                    }
                    c = findMax(c, minInRow);
                    SKrit.Text = c.value.ToString();
                    SAlt.Text = c.index.ToString();
                    c.value = 0;
                    c.index = 0;
                }
            }

            if (checkedListBox.GetItemChecked(3) && ValidateAlfa())
            {
                List<Cell> maxInRow = new List<Cell>();
                List<Cell> minInRow = new List<Cell>();
                List<Cell> m = new List<Cell>();

                double alfa = Convert.ToDouble(Alfa.Text);
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    maxInRow.Add(findMaxInRow(row, c));
                    minInRow.Add(findMinInRow(row, c));
                }

                for (int i = 0; i < dataGridView.SelectedRows.Count; i++)
                {
                    if (radioButtonWin.Checked)
                        c.value = alfa * maxInRow[i].value + (1 - alfa) * minInRow[i].value;
                    else
                        c.value = alfa * minInRow[i].value + (1 - alfa) * maxInRow[i].value;
                    c.index = maxInRow[i].index;
                    m.Add(c);
                }
                if (radioButtonWin.Checked)
                    c = findMax(c, m);
                else
                    c = findMin(c, m);
                GurvicKrit.Text = c.value.ToString();
                GurvicAlt.Text = c.index.ToString();
                c.value = 0;
                c.index = 0;
            }
        }
    }
}