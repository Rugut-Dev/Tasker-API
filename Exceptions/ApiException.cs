namespace TaskerAPI.Exceptions
{
    public class TaskNotFoundException : Exception
    {
        public TaskNotFoundException(Guid id) 
            : base($"Task with ID {id} was not found.") { }
    }

    public class UnauthorizedTaskAccessException : Exception
    {
        public UnauthorizedTaskAccessException() 
            : base("You are not authorized to access this task.") { }
    }

    public class DuplicateEmailException : Exception
    {
        public DuplicateEmailException() 
            : base("Email already exists.") { }
    }
} 