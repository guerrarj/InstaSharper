﻿using InstaSharper.Abstractions.Models.User;
using InstaSharper.Models.Response.User;

namespace InstaSharper.Infrastructure.Converters.User
{
    internal class UserConverter : IObjectConverter<InstaUserShort, InstaUserShortResponse>
    {
        public InstaUserShort Convert(InstaUserShortResponse source) =>
            new InstaUserShort
            {
                Pk = source.Pk,
                UserName = source.UserName,
                FullName = source.FullName,
                IsPrivate = source.IsPrivate,
                ProfilePicture = source.ProfilePicture,
                ProfilePictureId = source.ProfilePictureId,
                IsVerified = source.IsVerified,
                ProfilePicUrl = source.ProfilePicture,
                HasAnonymousProfilePicture = source.HasAnonymousProfilePicture.GetValueOrDefault()
            };
    }
}