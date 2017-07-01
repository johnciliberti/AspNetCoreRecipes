import React from 'react';
import PropTypes from 'prop-types';

const ArtistNameAndBio = ({artistName, artistBio}) => (
  <div className="artist-profile-text">
    <h1>{artistName.firstName} {artistName.lastName}</h1>
    <p>{artistBio}</p>
  </div>
);

ArtistNameAndBio.propTypes = {
  artistName: PropTypes.shape({
    firstName: PropTypes.string,
    lastName: PropTypes.string
  }).isRequired,
  artistBio: PropTypes.string.isRequired
};
export default ArtistNameAndBio;
