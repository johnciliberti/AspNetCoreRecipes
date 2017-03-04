declare module server {
	/** Provides Unit of work pattern for data access and exposes set of repository classes */
	interface unitOfWork {
		/** Allows queries and data management for data regarding Artist Skills */
		artistSkillRepository: any;
		/** Allows queries and data management for data regarding Genres */
		genreLookUpRepository: any;
		/** Allows queries and data management for data regarding Artists */
		artistRepository: any;
		/** Allows queries and data management for data regarding Collaboration Spaces */
		collaborationSpaceRepository: any;
		/** Allows queries and data management for data regarding Bands */
		bandRepository: any;
	}
}
