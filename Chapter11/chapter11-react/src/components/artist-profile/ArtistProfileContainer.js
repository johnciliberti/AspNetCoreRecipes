import React, { Component } from 'react';
import PropTypes from 'prop-types';
import ArtistProfileBanner from './ArtistProfileBanner';
import ArtistProfilePicture from './ArtistProfilePicture';
import ArtistNameAndBio from './ArtistNameAndBio';
import ArtistCollaborationList from './ArtistCollaborationList';
import ArtistProfileApi from '../../api/ArtistProfileApi';
import './artistprofile.css';

class ArtistProfileContainer extends Component {
  constructor(props) {
    super(props);
    this.state = {
      profileImage: props.profileImage,
      bannerImage: props.bannerImage,
      artistName: props.artistName,
      artistBio: props.artistBio
    };
  }

  componentWillMount() {
    ArtistProfileApi.getArtistProfile(1)
      .then((data) => {
        this.setState({
          profileImage: data.profileImageUrl,
          bannerImage: data.bannerImageUrl,
          artistName: { firstName: data.firstName, lastName: data.lastName },
          artistBio: data.bio
        });
      })
      .catch((error) => {
        console.error(`There has been a problem with your fetch operation: ${error.message}`);
      });
  }
  render() {
    return (
      <div className="container-fluid">
        <div className="row">
          <div className="col-lg-12">
            <div className="artist-profile">
              <ArtistProfileBanner bannerImage={this.state.bannerImage} />
              <ArtistProfilePicture profileImage={this.state.profileImage} />
              <ArtistNameAndBio
                artistName={this.state.artistName}
                artistBio={this.state.artistBio}
              />
            </div>
          </div>
        </div>
        <div className="row">
          <div className="col-lg-12">
            <h2>Collaboration Projects</h2>
            <ArtistCollaborationList />
          </div>
        </div>
      </div>
    );
  }
}

ArtistProfileContainer.propTypes = {
  profileImage: PropTypes.string,
  bannerImage: PropTypes.string,
  artistName: PropTypes.shape({
    firstName: PropTypes.string,
    lastName: PropTypes.string
  }),
  artistBio: PropTypes.string
};
ArtistProfileContainer.defaultProps = {
  profileImage: '/images/profileSample.jpg',
  bannerImage: '/images/SampleBackground1.jpg',
  artistName: { firstName: 'firstName', lastname: 'lastname' },
  artistBio: 'Artist Bio. Blaa blaa blaa ...'
};

export default ArtistProfileContainer;
