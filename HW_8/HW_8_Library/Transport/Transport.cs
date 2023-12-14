using HW_8_Library.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_8_Library.Transport
{
    public abstract class Transport
    {
        public abstract void Move();
        public abstract Engine Engine { get; set; }    
    }
}


//2.Реализовать структуру классов :
//Engine(содержит метод для включения двигателя),
//Transport(абстрактный класс), Car, Plane, абстрактные члены: 
//свойство типа Engine 
//метод Move. 
//Переопределение Move должно вызывать приватную логику движения наследников и включать двигатель.
