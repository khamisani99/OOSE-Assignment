using System;

namespace ClassLibrary2
{
    public class reciept
    {
        public int total(int qtyapple, int qtysamsung, int qtyhuawei, int qtyvivo, int qtysony, int qtymotorolla, int qtyoneplus, int apple, int samsung, int huawei, int vivo, int sony, int motorolla, int oneplus)
        {
            int tl = 0;
            tl = (qtyapple * apple) + (qtysamsung * samsung) + (qtyhuawei * huawei) + (qtyvivo * vivo) + (qtysony * sony) + (qtymotorolla * motorolla) + (qtyoneplus * oneplus);
            return tl;
        }
    }
}
