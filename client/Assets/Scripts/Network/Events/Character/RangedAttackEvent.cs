using Network.Objects;

namespace Network.Events.Character
{
    public class RangedAttackEvent : BasicEvent
    {
        public RequestEntity originEntity;
        public RequestEntity targetEntity;
        public int[] originField;
        public int[] targetField;
        public int value;

        public RangedAttackEvent(RequestEntity originEntity, RequestEntity targetEntity, int[] originField,
            int[] targetField, int value)
        {
            eventType = EventType.RangedAttackEvent;

            this.originEntity = originEntity;
            this.targetEntity = targetEntity;
            this.originField = originField;
            this.targetField = targetField;
            this.value = value;
        }

        public RangedAttackEvent()
        {
        }
    }
}
