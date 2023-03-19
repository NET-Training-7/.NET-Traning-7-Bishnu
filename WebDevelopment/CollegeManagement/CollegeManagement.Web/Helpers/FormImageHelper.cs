namespace CollegeManagement.Web.Helpers;
public class FormImageHelper
{
    public static string SaveProfileImage(IFormFile image)
    {
        if (image is null)
            return string.Empty;

        //Save avatar to phyical folder        
        var fileName = $"{Guid.NewGuid()}_{image.FileName}"; //4ea9773c-e77e-4c3c-a075-c97dcffee0fe_My Photo.jpg
        var appFolder = Directory.GetCurrentDirectory();
        var imageFolderPathRelative = $"/images/profiles/{fileName}";
        var imageFolderPathAbsolute = appFolder + "/wwwroot/" + imageFolderPathRelative;

        var avatar = File.Create(imageFolderPathAbsolute);
        image.CopyTo(avatar);
        avatar.Close();

        return imageFolderPathRelative;
    }
}
