using Iterator.Example_1.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Example_1.Concrete
{
    // Somut Yineleyiciler, çeşitli geçiş algoritmaları uygular. Bu sınıflar her zaman geçerli çapraz konumu saklar.
    class AlphabeticalOrderIterator : Iterator_
    {
        private WordsCollection _collection;

        // Geçerli çapraz konumu saklar. Bir yineleyici, özellikle belirli bir koleksiyon türüyle çalışması gerektiğinde, yineleme durumunu depolamak için birçok başka alana sahip olabilir.
        private int _position = -1;

        private bool _reverse = false;

        public AlphabeticalOrderIterator(WordsCollection collection, bool reverse = false)
        {
            this._collection = collection;
            this._reverse = reverse;

            if (reverse)
            {
                this._position = collection.getItems().Count;
            }
        }

        public override object Current()
        {
            return this._collection.getItems()[_position];
        }

        public override int Key()
        {
            return this._position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = this._position + (this._reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < this._collection.getItems().Count)
            {
                this._position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            this._position = this._reverse ? this._collection.getItems().Count - 1 : 0;
        }
    }

}
