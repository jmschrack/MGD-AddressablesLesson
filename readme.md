# how to use addressables
basically just the Resources folder on crack
- look up via string
- look up via assetReference

Always look up the documentation via the package manager. It can change wildly.

## gotchas to watch out for
- loading something that is already loaded or in the process of being loaded can throw an error
- on complete fires whether you are ready or not
- stored by filetype on disk, not script type.
ScriptableObjects are your new best friend


# how to host content and do updates
- just throw it on a plain ol' file server. That's it.
- Make sure `Build Remote Catalog` is set to true in your settings.
- If testing with selfhosting, remove the `[BuildTarget]` from remote load path
- `Play Mode:Asset Library` will almost always work,  Test with `Play Mode:Use Existing Build`
- If doing a content update, the content must be in a "Remote Load" group. You can even move stuff from one group to another and it will work.


# secrets
- how to use async/await to make life easy:  Just use `.Task`  to allow for `await`ing
- how to secretly use scene loading: name your scene the same thing as it was in the SceneList.  Then you can just replace "SceneManagement.LoadSceneAsync" with "Addressables.LoadSceneAsync"
- You can actually host your remote content on Github. Check out the "ServerData" branch on this repo.  In your repo settings, go to Pages>Source Branch: *set it to whatever branch will host your files*