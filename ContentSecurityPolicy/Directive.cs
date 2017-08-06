using System;
using System.Collections.Generic;
using System.Text;

namespace ContentSecurityPolicy
{
    public abstract class Directive : IEquatable<Directive>
    {
        private static readonly string Separetor = ";";

        private readonly string _key;
        private readonly IList<string> _value;

        public Directive(string key)
        {
            if (string.IsNullOrWhiteSpace(key))
            {
                throw new ArgumentException(nameof(key));
            }

            _key = key;
            _value = new List<string>();
        }

        public string Key
        {
            get
            {
                return _key;
            }
        }

        public IList<string> Value
        {
            get
            {
                return _value;
            }
        }

        public bool Equals(Directive other)
        {
            return other != null && _key == other.Key;
        }

        public void Merge(Directive directive)
        {
            if (directive == null)
            {
                throw new ArgumentNullException(nameof(directive));
            }

            if (!directive.Equals(this))
            {
                throw new ArgumentException(nameof(directive));
            }

            AddValues(directive.Value);
        }

        protected virtual void AddValues(IList<string> values)
        {
            foreach (var value in values)
            {
                AddValue(value);
            }
        }

        protected virtual void AddValue(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(nameof(value));
            }

            //value = value.ToLowerInvariant();

            if (value == Constants.NoneKeyword)
            {
                _value.Clear();
                _value.Add(Constants.NoneKeyword);
            }
            else
            {
                _value.Remove(Constants.NoneKeyword);
                _value.Add(value);
            }
        }

        protected virtual void ClearValue()
        {
            _value.Clear();
        }

        public virtual string Compose()
        {
            var sb = new StringBuilder(_key);

            foreach (var item in _value)
            {
                sb.Append($" {item}");
            }

            sb.Append($"{Directive.Separetor} ");

            return sb.ToString();
        }
    }
}
