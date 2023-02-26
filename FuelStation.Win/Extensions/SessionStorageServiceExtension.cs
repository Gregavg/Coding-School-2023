//using System.Text.Json;
//using System.Text;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Http.Extensions;


//namespace FuelStation.Win.Extensions {
//    public static class SessionStorageServiceExtension {
//        public static async Task SaveItemEncryptedAsync<T>(this ISession session, string key, T item) {
//            var itemJson = JsonSerializer.Serialize(item);
//            var itemJsonBytes = Encoding.UTF8.GetBytes(itemJson);
//            var base64Json = Convert.ToBase64String(itemJsonBytes);
//            await session.LoadAsync();
//            session.Set(key, Encoding.ASCII.GetBytes(base64Json));
//            await session.CommitAsync();
//        }

//        public static async Task<T> ReadEncryptedItemAsync<T>(this ISession session, string key) {
//            var base64Json = session.GetString(key);
//            if (base64Json == null)
//                return default(T);
//            var itemJsonBytes = Convert.FromBase64String(base64Json);
//            var itemJson = Encoding.UTF8.GetString(itemJsonBytes);
//            var item = JsonSerializer.Deserialize<T>(itemJson);
//            return item;
//        }
//    }
//}
