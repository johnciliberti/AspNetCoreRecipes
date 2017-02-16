declare module server {
	/** Provides Unit of work pattern for data access and exposes set of repository classes */
	interface unitOfWork {
		/** Allows queries and data management for data regarding Artist Skills */
		artistSkillRepository: {
		};
		/** Allows queries and data management for data regarding Genres */
		genreLookUpRepository: {
		};
		/** Allows queries and data management for data regarding Artists */
		artistRepository: {
		};
		/** Allows queries and data management for data regarding Collaboration Spaces */
		collaborationSpaceRepository: {
		};
		/** Allows queries and data management for data regarding Bands */
		bandRepository: {
		};
	}
}
