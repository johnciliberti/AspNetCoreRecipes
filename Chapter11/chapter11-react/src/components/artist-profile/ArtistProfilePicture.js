import React from 'react';
import PropTypes from 'prop-types';

const ArtistProfilePicture = ({ profileImage }) => (
  <img
    className="artist-profile-image img-circle img-thumbnail"
    src={profileImage}
    alt="Artist Avatar"
  />
);

ArtistProfilePicture.propTypes = {
  profileImage: PropTypes.string.isRequired
};

export default ArtistProfilePicture;
