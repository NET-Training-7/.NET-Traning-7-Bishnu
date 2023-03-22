namespace CollegeManagement.Web.Extensions;
public static class IFormFileExtensions
{
    public static string SaveProfileImage(this IFormFile image)
    {
        if (image is null)
            return string.Empty;

        // Save avatar to physical folder

        var fileName = $"{Guid.NewGuid()}_{image.FileName}"; //4ea97773c-e77e-4c3c-a075-c9asdf image.jpg
        var appFolder = Directory.GetCurrentDirectory();
        var imageFolderPathRelative = $"/images/Profile/{fileName}";
        var imageFolderPathAbsolute = appFolder + "/wwwroot/" + imageFolderPathRelative;

        var avatar = File.Create(imageFolderPathAbsolute);
        image.CopyTo(avatar);
        avatar.Close();

        return imageFolderPathRelative;
    }
}
