﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.categoryDto;

namespace DomainLayer.PostDto
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string UserId { get; set; }
        public int LikesCount { get; set; }
        public List<DomainLayer.CommentDto.CommentDto> Comments { get; set; } = new List<DomainLayer.CommentDto.CommentDto>();
        public List<DomainLayer.categoryDto.CategoryDto> categories { get; set; } = new List<DomainLayer.categoryDto.CategoryDto>();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
