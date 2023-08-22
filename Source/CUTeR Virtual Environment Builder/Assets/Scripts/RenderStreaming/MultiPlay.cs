using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Unity.RenderStreaming.Samples
{
    public class MultiPlay : SignalingHandlerBase,
        IOfferHandler, IAddChannelHandler, IDisconnectHandler, IDeletedConnectionHandler
    {
        [SerializeField] GameObject prefab;
        private List<string> connectionIds = new List<string>();
        private List<Component> streams = new List<Component>();
        private Dictionary<string, GameObject> dictObj = new Dictionary<string, GameObject>();

        public override IEnumerable<Component> Streams => streams;
        public void OnAddChannel(SignalingEventData eventData)
        {
            var obj = dictObj[eventData.connectionId];
            var channels = obj.GetComponentsInChildren<IDataChannel>();
            
            var channel = channels.FirstOrDefault(_ => !_.IsLocal && !_.IsConnected);
            channel?.SetChannel(eventData);
        }

        public void OnDeletedConnection(SignalingEventData eventData)
        {
            Disconnect(eventData.connectionId);
        }

        public void OnDisconnect(SignalingEventData eventData)
        {
            Disconnect(eventData.connectionId);
        }

        private void Disconnect(string connectionId)
        {
            if (!connectionIds.Contains(connectionId))
                return;
            connectionIds.Remove(connectionId);

            var obj = dictObj[connectionId];
            var sender = obj.GetComponentInChildren<StreamSenderBase>();
            var inputChannel = obj.GetComponentInChildren<InputReceiver>();
            //var multiplayChannel = obj.GetComponentInChildren<MultiplayChannel>();

            dictObj.Remove(connectionId);
            Object.Destroy(obj);

            RemoveSender(connectionId, sender);
            RemoveChannel(connectionId, inputChannel);
            //RemoveChannel(connectionId, multiplayChannel);

            streams.Remove(sender);
            streams.Remove(inputChannel);
            //streams.Remove(multiplayChannel);

            if (ExistConnection(connectionId))
                DeleteConnection(connectionId);
        }

        public void OnOffer(SignalingEventData eventData)
        {
            Debug.Log("New connection");
            Debug.Log(eventData.channel);
            if (connectionIds.Contains(eventData.connectionId))
            {
                Debug.Log($"Already answered this connectionId : {eventData.connectionId}");
                return;
            }
            connectionIds.Add(eventData.connectionId);

            var initialPosition = new Vector3(0, 3, 0);
            var newObj = Instantiate(prefab, initialPosition, Quaternion.identity);
            dictObj.Add(eventData.connectionId, newObj);

            var sender = newObj.GetComponentInChildren<StreamSenderBase>();


            var inputChannel = newObj.GetComponentInChildren<InputReceiver>();


            streams.Add(sender);
            streams.Add(inputChannel);

            AddSender(eventData.connectionId, sender);
            AddChannel(eventData.connectionId, inputChannel);

            SendAnswer(eventData.connectionId);
        }

        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}