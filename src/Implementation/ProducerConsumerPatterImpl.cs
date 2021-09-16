using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
using ProdCons.BL;

namespace ProdCons.Implementation
{
    public class ProducerConsumerPatternImpl : IProducerConsumerImpl
    {
        public async Task ProduceAndConsume<T>(int howMany, IProducerConsumer<T> producerConsumer)
        {
            var queue = new ConcurrentBag<T>();

            // Tarea para producir.
            var produceTask = Task.Run(() => {
                Parallel.For(0, howMany,
                    _ => queue.Add(producerConsumer.Produce()));
            });	
            
            // Tarea para consumir.
            var consumeTask = Task.Run(() => {
                int consumed = 0;
                while (consumed < howMany)
                {
                    if (queue.TryTake(out T value))
                    {
                        producerConsumer.Consume(value);
                        consumed++;
                    }
                }     
            });
            
            await Task.WhenAll(produceTask, consumeTask);
        }
    }
}