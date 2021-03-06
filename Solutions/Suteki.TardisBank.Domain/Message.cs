namespace Suteki.TardisBank.Domain
{
    using System;

    using SharpArch.Domain.DomainModel;

    public class Message : EntityWithTypedId<string>
    {
        public Message(DateTime date, string text, User user)
        {
            this.Date = date;
            this.Text = text;
            this.HasBeenRead = false;
        }

        protected Message()
        {
        }

        public virtual void Read()
        {
            this.HasBeenRead = true;
        }

        public virtual DateTime Date { get; protected set; }
        public virtual string Text { get; protected set; }

        public virtual bool HasBeenRead { get; protected set; }
    }
}