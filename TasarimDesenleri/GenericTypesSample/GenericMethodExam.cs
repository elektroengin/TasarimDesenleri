namespace GenericTypesSample
{
    public class GenericMethodExam
    {
        // Aslında burada T : methodun gneric olduğunu ve T tür paremetresi methodun işleyeceği türü belirtir.
        public T GenericMethod<T>(T genericMethod)
        {
            return genericMethod;
        }
    }
}
