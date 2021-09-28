using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using MetricsAgent.DAL.Interfaces;
using MetricsAgent.DAL.Models;
using MetricsAgent.DAL;
using Dapper;
using System.Linq;

namespace MetricsAgent.DAL.Repositories
{
    public interface ICpuMetricsRepository : IRepository<CpuMetric> { }
    public interface IDotNetMetricsRepository : IRepository<DotNetMetric> { }
    public interface IHddMetricsRepository : IRepository<HddMetric> { }
    public interface INetworkMetricsRepository : IRepository<NetworkMetric> { }
    public interface IRamMetricsRepository : IRepository<RamMetric> { }

    public abstract class BaseMetricsRepository<TMetric> where TMetric : baseMetric
    {
        //строка подключения
        private const string ConnectionString = "Data Source=metrics.db; Version=3;Pooling=True;Max Pool Size=100;";
        // инжектируем соединение с базой данных в наш репозиторий через конструктор

        public BaseMetricsRepository()
        {
            // добавляем парсилку типа TimeSpan в качестве подсказки для SQLite
            //SqlMapper.AddTypeHandler(new TimeSpanHandler());
        }

        public void Create(TMetric item)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                //  запрос на вставку данных с плейсхолдерами для параметров
                connection.Execute("INSERT INTO {TMetric}(value, time) VALUES(@value, @time)",
                    // анонимный объект с параметрами запроса
                    new
                    {
                        // value подставится на место "@value" в строке запроса
                        // значение запишется из поля Value объекта item
                        value = item.Value,

                        // записываем в поле time количество секунд
                        time = item.Time
                    });
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("DELETE FROM {TMetric} WHERE id=@id",
                    new
                    {
                        id = id
                    });
            }
        }

        public void Update(TMetric item)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Execute("UPDATE {TMetric} SET value = @value, time = @time WHERE id=@id",
                    new
                    {
                        value = item.Value,
                        time = item.Time,
                        id = item.Id
                    });
            }
        }

        public IList<TMetric> GetAll()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                // читаем при помощи Query и в шаблон подставляем тип данных
                // объект которого Dapper сам и заполнит его поля
                // в соответсвии с названиями колонок
                return connection.Query<TMetric>("SELECT Id, Time, Value FROM {TMetric}").ToList(); //здесь ошибка?
            }

        }

        public TMetric GetById(int id)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                return connection.QuerySingle<TMetric>("SELECT Id, Time, Value FROM {TMetric} WHERE id=@id",
                    new { id = id });
            }
        }
    }
}
