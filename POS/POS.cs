using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class frm_POS : Form
    {
        private Dictionary<Button, decimal> menuItems;
        private List<string> orderedItems;
        private decimal totalAmount;

        public frm_POS()
        {
            InitializeComponent();
            InitializeMenuItems();
            ResetOrder();
        }

        private void InitializeMenuItems()
        {
            menuItems = new Dictionary<Button, decimal>
            {
                { btnBeer, 120 },
                { btnTequila, 180 },
                { btnWhisky, 350 },
                { btnWine, 320 }
            };

            foreach (var menuItem in menuItems)
            {
                menuItem.Key.Click += MenuItem_Click;
            }
        }

        private void ResetOrder()
        {
            orderedItems = new List<string>();
            totalAmount = 0;
            UpdateOrderList();
            UpdateTotalAmount();
        }

        private void MenuItem_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            decimal itemPrice = menuItems[btn];
            orderedItems.Add(btn.Text);
            totalAmount += itemPrice;
            UpdateOrderList();
            UpdateTotalAmount();
        }

        private void UpdateOrderList()
        {
            Dictionary<string, int> itemCounts = new Dictionary<string, int>();

            foreach (string item in orderedItems)
            {
                if (itemCounts.ContainsKey(item))
                    itemCounts[item]++;
                else
                    itemCounts[item] = 1;
            }

            StringBuilder sb = new StringBuilder();

            foreach (var pair in itemCounts)
            {
                string itemName = pair.Key;
                int itemQuantity = pair.Value;
                decimal itemPrice = menuItems.FirstOrDefault(x => x.Key.Text == itemName).Value;
                decimal itemTotalPrice = itemPrice * itemQuantity;

                sb.AppendLine($"{itemName} x{itemQuantity} 共 {itemTotalPrice.ToString("C0")} 元");
            }

            labList.Text = sb.ToString();
        }

        private void UpdateTotalAmount()
        {
            labCount.Text = totalAmount.ToString("C0");
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            labList.Text = string.Empty;
            ResetOrder();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            if (orderedItems.Count == 0)
            {
                SystemSounds.Exclamation.Play();
                string title = "確認付款";
                string message = "尚未點餐";
                MessageBox.Show(message, title, MessageBoxButtons.OK);
            }
            else
            {
                string title = "確認付款";
                string message = "總金額: " + totalAmount.ToString("C0");
                DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {

                }
                else
                {

                }
            }
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            if (orderedItems.Count == 0)
            {
                SystemSounds.Exclamation.Play();
                string title = "確認付款";
                string message = "尚未點餐";
                MessageBox.Show(message, title, MessageBoxButtons.OK);
            }
            else
            {
                decimal discountedAmount = totalAmount * 0.9m; // 折扣後金額

                string title = "確認付款";
                string message = $"總金額: {totalAmount.ToString("C0")}\n折扣後金額: {discountedAmount.ToString("C0")}";
                DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {

                }
                else
                {

                }
            }
        }

    }
}
