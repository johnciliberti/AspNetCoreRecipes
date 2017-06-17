
class ArtistProfileApi {
  static getArtistProfile(artistId) {
    return fetch(`/api/profile/${artistId}`,
      {
        method: 'GET',
        headers: {
          'Accept': 'application/json',
          'Content-Type': 'application/json'
        }
      }
    )
      .then(response => response.json());
  }
}

export default ArtistProfileApi;
