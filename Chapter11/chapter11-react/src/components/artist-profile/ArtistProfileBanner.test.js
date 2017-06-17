import React from 'react';
import ReactDOM from 'react-dom';
import ArtistProfileBanner from './ArtistProfileBanner';

describe('ArtistProfileBanner', () => {
  it('ArtistProfileBanner Renders without crashing', () => {
    const div = document.createElement('div');
    ReactDOM.render(<ArtistProfileBanner bannerImage={'/images/SampleBackground1.jpg'} />, div);
  });
});

