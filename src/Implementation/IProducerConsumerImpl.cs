using System;
using System.Threading.Tasks;
using ProdCons.BL;

namespace ProdCons.Implementation
{
    public interface IProducerConsumerImpl
    {
        Task ProduceAndConsume<T>(int howMany, IProducerConsumer<T> producerConsumer);
    }
}