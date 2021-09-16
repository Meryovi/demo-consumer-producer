using System;

namespace ProdCons.BL
{
    public interface IProducerConsumer<T>
    {
        T Produce();

        void Consume(T value);
    }
}