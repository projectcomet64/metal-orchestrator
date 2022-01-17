using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using M64MMOrkestrator.KIO;
using Newtonsoft.Json.Serialization;

namespace M64MMOrkestrator.KIO
{
    public class KIOTypesBinder : ISerializationBinder
    {
        private DefaultSerializationBinder binder = new DefaultSerializationBinder();

        /// <summary>
        /// Add the types of special Racks to be recognized as Orchestrable whenever necessary in here, so the (de)serializer can do its thing.
        /// </summary>
        public IList<Type> KnownTypes { get; } = new List<Type>()
        {
            typeof(Vector3KeyframeRack),
            typeof(XYAngleKeyframeRack)
        };

        public Type BindToType(string assemblyName, string typeName)
        {
            Type found = KnownTypes.SingleOrDefault(t => t.Name == typeName);
            if (assemblyName == "KnownOrchestrableRackType" && found != null)
            {
                return found;
            }
            return binder.BindToType(assemblyName, typeName);
        }

        public void BindToName(Type serializedType, out string assemblyName, out string typeName)
        {
            if (KnownTypes.Select(x => x.Name).Contains(serializedType.Name)) {
                assemblyName = "KnownOrchestrableRackType";
            }
            else
            {
                assemblyName = serializedType.Assembly.FullName;
            }
            typeName = serializedType.Name;
        }
    }
}