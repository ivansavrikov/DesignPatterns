using System;
using System.Collections.Generic;

namespace Patterns.Core
{
    /// <summary>
    /// Singleton (одиночка) - Порождающий паттерн проектирования.
    /// Обеспечивает использование единственного экзмепляра класса из любой точки приложения.
    /// В комерческой разработке часто является антипаттерном.
    /// Не рекомендуется использовать, из-за вероятности возникания проблем в будущем при поддержке проекта.
    /// </summary>
    public class Logger
    {
        public static Logger Instance { get; private set; }

        /// <summary>
        /// Статистический конструктор вызывается единственный раз при 
        /// первом взаимодействии с данным классом.
        /// Использование в данном контексте, необходимо для корректной работы в многопоточночной среде
        /// </summary>
        static Logger()
        {
            Instance = new Logger();
            Instance.AddLog("Singleton Logger Created");
        }

        /// <summary>
        /// Приватный конструктор, исключает создание нового экземпляра из вне
        /// </summary>
        private Logger()
        {
            
        }

        private readonly List<string> _logs = new List<string>();
        private static int _logIndex = 0;

        public delegate void LogAddedEventHandler(string log);
        public event LogAddedEventHandler LogAdded;

        public void AddLog(string log)
        {
            log = $"log {_logIndex}: {log}";
            _logs.Add(log);
            _logIndex++;
            LogAdded?.Invoke(log);
        }
    }
}