using System;
using System.ComponentModel;

namespace Assignment7
{

    /*
     * CAVEATS Denoted by --
     *
     * --The biggest problem with making a particular property not null is that
     * now our assumptions in the outside world don't match our reality. In other words,
     * if im in a particular situation where i need to assign my Value property to null maybe for
     * error checking or edge cases or just because i need that sort of functionality, Im going to create a sh** ton
     * of problems for myself by removing this ability to not exist from my property. Namely when im trying to check for invalid
     * data rather than for data that is just default. Like maybe in a situation where a user on a website makes a new profile name,
     * the default value is different then the empty string value. (Billion Dollar Problem)
     *
     * --Another problem with this is that even though the generic type is not nullable, the reference it is wrapped in (aka our class) is nullable.
     * There is nothing we could find that prevents the user from writing the following code.
     *
     *   NotNullableReference<SomeClass> theClass = new NotNullableReference<SomeClass>;
     *   theClass = null;
     *
     * --Because we need to ensure that the item will not be null, T is restricted to reference types that have a
     * Default value Constructor, there is no way to fix this with-out losing the "not-null assurance" functionality.
     *
     */
    public class NotNullableReference<T>
        where T : new()
    {
        private T _Value;

        public T Value
        {
            get => _Value;
            set
            {
                if (value == null)
                {
                    _Value = new T();
                }
                else
                {
                    _Value = value;
                }
            }
        }

    }
}