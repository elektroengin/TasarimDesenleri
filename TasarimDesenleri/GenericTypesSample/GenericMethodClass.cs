namespace GenericTypesSample
{
    public class GenericMethodClass<T>
    {
        private T data;

        public GenericMethodClass(T data)
        {
            this.data = data; 
        }

        public T Data()
        {
            return data;
        }

    }
}
