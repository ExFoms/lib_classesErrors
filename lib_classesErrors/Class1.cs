// Энумератор ошибок глобальный 

public class clsErrors
{
    public enum GateError
    {
        comments,
        errorFileRead,
        errorInsertInDB,
        errorPerformanceMetod,
        errorInicializationMetod,
        StopedMetodOnDemand
    }
    public static string ToString(GateError e)
    {
        string result = "";
        switch (e)
        {
            case GateError.comments:
                result = string.Empty; break;
            case GateError.errorFileRead:
                result = "Ошибка чтения файла"; break;
            case GateError.errorInsertInDB:
                result = "Ошибка добавления записи в БД"; break;
            case GateError.errorPerformanceMetod:
                result = "Ошибка в процессе выполнения метода"; break;
            case GateError.errorInicializationMetod:
                result = "Ошибка инициализации метода"; break;
            case GateError.StopedMetodOnDemand:
                result = "Метод остановлен по требованию"; break;
        }
        return result;
    }
}
