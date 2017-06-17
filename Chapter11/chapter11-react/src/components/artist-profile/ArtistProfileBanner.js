import React from 'react';
import PropTypes from 'prop-types';

const ArtistProfileBanner = ({ bannerImage }) => (
  <img
    className="artist-profile-banner"
    src={bannerImage}
    alt="Artist profile large background"
  />
);

ArtistProfileBanner.propTypes = {
  bannerImage: PropTypes.string.isRequired
};

export default ArtistProfileBanner;

