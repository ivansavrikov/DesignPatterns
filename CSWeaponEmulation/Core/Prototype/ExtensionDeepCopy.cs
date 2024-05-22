using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Patterns.Core
{
    static class ExtensionMethods
    {
        internal static T DeepCopy<T>(this T self)
        {
            if (!typeof(T).IsSerializable)
                throw new Exception("Объект должен быть сериализуем");

            if(ReferenceEquals(self, null))
                return default(T);

            var formatter = new BinaryFormatter();

            using(var stream = new MemoryStream())
            {
                formatter.Serialize(stream, self);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)formatter.Deserialize(stream);
            }
        }
    }
}