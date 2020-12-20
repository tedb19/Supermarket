﻿using Supermarket.API.Domain.Models;


namespace Supermarket.API.Domain.Communication
{
    public class CategoryResponse: BaseResponse
    {
        public Category Category { get; protected set; }

        private CategoryResponse(bool success, string message, Category category) : base(success, message)
        {
            Category = category;
        }

        public CategoryResponse(Category category) : this(true, string.Empty, category)
        { }

        public CategoryResponse(string message) : this(false, message, null)
        { }
    }
}
