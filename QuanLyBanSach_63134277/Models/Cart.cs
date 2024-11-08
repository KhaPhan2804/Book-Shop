using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanSach_63134277.Models
{
    public class CartItem
    {
        public Sach _sach { get; set; }
        public int _sach_soluong { get; set; }


    }
    public class Cart
    {
        List<CartItem> items = new List<CartItem>();
        public IEnumerable<CartItem> Items
        {
            get { return items; }
        }
        public void Add(Sach _sa, int _sl = 1)
        {
            var item = items.FirstOrDefault(s => s._sach.ma_Sach == _sa.ma_Sach);
            if (item == null)
            {
                items.Add(new CartItem
                {
                    _sach = _sa,
                    _sach_soluong = _sl
                });
            }
            else
            {
                item._sach_soluong += _sl;
            }
        }
        public void Update_Soluong(int id, int soluong)
        {
            var item = items.Find(s => s._sach.ma_Sach == id);
            if (item != null)
            {
                item._sach_soluong = soluong;
            }
        }
        public double Total()
        {
            var total = items.Sum(s => s._sach.giatien * s._sach_soluong);
            return (double)total;
        }
        public void Remove(int id)
        {
            items.RemoveAll(s => s._sach.ma_Sach == id);
        }
        public int Tong_SL()
        {
            return items.Sum(s => s._sach_soluong);
        }
        public void ClearCart()
        {
            items.Clear();
        }
    }
}