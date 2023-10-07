namespace MyArch.Services.Response
{
    public static class ApiResponseHandler
    {
        public static ApiResponse<T> Deleted<T>(T entity, string message = null)
        {
            return new ApiResponse<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                Message = message ?? "Deleted Successfully"
            };
        }
        public static ApiResponse<T> Success<T>(T entity, string? message = null, object Meta = null)
        {
            return new ApiResponse<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.OK,
                Succeeded = true,
                //Message = message ?? "Added Successfully",
                Meta = Meta
            };
        }
        public static ApiResponse<T> Unauthorized<T>()
        {
            return new ApiResponse<T>()
            {
                StatusCode = System.Net.HttpStatusCode.Unauthorized,
                Succeeded = true,
                Message = "UnAuthorized"
            };
        }
        public static ApiResponse<T> BadRequest<T>(string? Message = null)
        {
            return new ApiResponse<T>()
            {
                StatusCode = System.Net.HttpStatusCode.BadRequest,
                Succeeded = false,
                Message = Message == null ? "Bad Request" : Message
            };
        }

        public static ApiResponse<T> UnprocessableEntity<T>(T entity, string Message = null)
        {
            return new ApiResponse<T>()
            {
                StatusCode = System.Net.HttpStatusCode.UnprocessableEntity,
                Succeeded = false,
                Message = Message == null ? "Unprocessable Entity" : Message,
                Data = entity,

            };
        }

        public static ApiResponse<T> NotFound<T>(string message = null)
        {
            return new ApiResponse<T>()
            {
                StatusCode = System.Net.HttpStatusCode.NotFound,
                Succeeded = false,
                Message = message == null ? "Not Found" : message
            };
        }

        public static ApiResponse<T> Created<T>(T entity, object Meta = null)
        {
            return new ApiResponse<T>()
            {
                Data = entity,
                StatusCode = System.Net.HttpStatusCode.Created,
                Succeeded = true,
                Message = "Created",
                Meta = Meta
            };
        }
        public static ApiResponse<T> NoContent<T>()
        {
            return new ApiResponse<T>()
            {
                StatusCode = System.Net.HttpStatusCode.NoContent,
                Succeeded = true,
                //Message = message ?? "No Content",
                //Meta = Meta,
                //Data = entity,

            };
        }
    }
}
