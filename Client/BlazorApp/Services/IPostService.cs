using Shared.DTOs.Posts;

namespace BlazorApp.Services;

public interface IPostService
{
    Task<PostDto> AddPostAsync(CreatePostDto request);
    Task<List<PostDto>> GetManyPostsAsync();
    Task<PostDto> GetSinglePostAsync(int id);
    Task<PostDto> UpdatePostAsync(int id, UpdatePostDto request);
    Task DeletePostAsync(int id);
}