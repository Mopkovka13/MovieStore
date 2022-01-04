using System;

namespace MovieStore.Interfaces
{
    public interface IShowcase
    {
        uint Id { get; }
        string Name { get; set; }
        int Capacity { get; set; }
        DateTime CreateDate { get; }
        //DateTime DeleteTime { get; } Так и не понял для чего, если удаляем, то посмотреть уже негде будет :D
        //Был вариант удалять не до конца
        //Переместить в корзину, а там предложить уже полное удаление
        //В начале сделать bool - Активная витрина или нет, тогда DeleteTime Время, когда она стала неактивной 

        void ShowProducts();
    }
}
